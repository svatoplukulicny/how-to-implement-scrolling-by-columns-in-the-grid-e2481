Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace WindowsApplication3
	Public Class GridHScrollHelper
		Private view As GridView

		Public Sub New(ByVal view As GridView)
			Me.view = view
		End Sub

		Public Sub EnableScrollByColumns()
			AddHandler Me.view.LeftCoordChanged, AddressOf OnLeftCoordChanged
		End Sub

		Private Sub OnLeftCoordChanged(ByVal sender As Object, ByVal e As EventArgs)
			If leftCoordChanged <> 0 Then
				Return
			End If
			BeginScroll()
			Try
				Dim firstColumnInfo As GridColumnInfoArgs = GetFirstNonFixedColumnInfo()
				If firstColumnInfo Is Nothing Then
					Return
				End If
				Dim index As Integer = ViewInfo.ColumnsInfo.IndexOf(firstColumnInfo)
				If IsRight Then
					If ScrollToNextColumn Then
						If index < ViewInfo.ColumnsInfo.Count - 1 Then
							index += 1
							Dim nextColumnInfo As GridColumnInfoArgs = ViewInfo.ColumnsInfo(index)
							SetLeftCoord(nextColumnInfo.Bounds.Right - Indent - 2, True)
						End If
					Else
						SetLeftCoord(firstColumnInfo.Bounds.Right - Indent - 2, True)
					End If
				Else
					If firstColumnInfo.Column.VisibleIndex <> 0 Then
						SetLeftCoord(firstColumnInfo.Bounds.Width - firstColumnInfo.Bounds.Right + Indent, False)
					Else
						SetLeftCoord(view.LeftCoord, False)
					End If
				End If
				oldLeftCoord = view.LeftCoord
			Finally
				EndScroll()
			End Try

		End Sub
		Private ReadOnly Property Indent() As Integer
			Get
				Return ViewInfo.ViewRects.FixedLeft.Width + ViewInfo.ViewRects.IndicatorWidth
			End Get
		End Property

		Private Function GetFirstNonFixedColumnInfo() As GridColumnInfoArgs
			Dim cArgs As GridColumnInfoArgs = Nothing
			For Each args As GridColumnInfoArgs In ViewInfo.ColumnsInfo
				If args.Column IsNot Nothing AndAlso args.Column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None AndAlso args.Bounds.Left <= Indent Then
					cArgs = args
				End If
			Next args
			Return cArgs
		End Function

		Private Sub SetLeftCoord(ByVal delta As Integer, ByVal isRight As Boolean)
			If isRight Then
				view.LeftCoord += delta
			Else
				view.LeftCoord -= delta
			End If
		End Sub

		Private leftCoordChanged As Integer = 0, oldLeftCoord As Integer = 0

		Private Sub EndScroll()
			leftCoordChanged -= 1
		End Sub

		Private Sub BeginScroll()
			leftCoordChanged += 1
		End Sub

		Private ReadOnly Property ViewInfo() As GridViewInfo
			Get
				Return TryCast(view.GetViewInfo(), GridViewInfo)
			End Get
		End Property

		Private ReadOnly Property IsRight() As Boolean
			Get
				Return view.LeftCoord > oldLeftCoord
			End Get
		End Property

		Private ReadOnly Property ScrollToNextColumn() As Boolean
			Get
				Dim args As GridColumnInfoArgs = GetFirstNonFixedColumnInfo()
				Return args.Bounds.Right <= Indent
			End Get
		End Property

	End Class
End Namespace
