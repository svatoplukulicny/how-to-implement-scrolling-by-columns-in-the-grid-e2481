Imports Microsoft.VisualBasic
Imports System.ComponentModel

Namespace WindowsApplication3
	Public NotInheritable Class ItemList
		Private Sub New()
		End Sub
		Public Shared Function GetList() As BindingList(Of Item)
			Dim list = New BindingList(Of Item)()
			For i As Integer = 0 To 49
				list.Add(New Item() With {.Column1 = "Test1" & i, .Column2 = "Test2" & i, .Column3 = "Test3" & i, .Column4 = "Test4" & i, .Column5 = "Test5" & i, .Column6 = "Test6" & i, .Column7 = "Test7" & i, .Column8 = "Test8" & i, .Column9 = "Test9" & i, .Column10 = "Test10" & i, .Column11 = "Test11" & i, .Column12 = "Test12" & i, .Column13 = "Test13" & i, .Column14 = "Test14" & i, .Column15 = "Test15" & i, .Column16 = "Test16" & i})
			Next i
			Return list
		End Function
	End Class
	Public Class Item
		Private privateColumn1 As String
		Public Property Column1() As String
			Get
				Return privateColumn1
			End Get
			Set(ByVal value As String)
				privateColumn1 = value
			End Set
		End Property
		Private privateColumn2 As String
		Public Property Column2() As String
			Get
				Return privateColumn2
			End Get
			Set(ByVal value As String)
				privateColumn2 = value
			End Set
		End Property
		Private privateColumn3 As String
		Public Property Column3() As String
			Get
				Return privateColumn3
			End Get
			Set(ByVal value As String)
				privateColumn3 = value
			End Set
		End Property
		Private privateColumn4 As String
		Public Property Column4() As String
			Get
				Return privateColumn4
			End Get
			Set(ByVal value As String)
				privateColumn4 = value
			End Set
		End Property
		Private privateColumn5 As String
		Public Property Column5() As String
			Get
				Return privateColumn5
			End Get
			Set(ByVal value As String)
				privateColumn5 = value
			End Set
		End Property
		Private privateColumn6 As String
		Public Property Column6() As String
			Get
				Return privateColumn6
			End Get
			Set(ByVal value As String)
				privateColumn6 = value
			End Set
		End Property
		Private privateColumn7 As String
		Public Property Column7() As String
			Get
				Return privateColumn7
			End Get
			Set(ByVal value As String)
				privateColumn7 = value
			End Set
		End Property
		Private privateColumn8 As String
		Public Property Column8() As String
			Get
				Return privateColumn8
			End Get
			Set(ByVal value As String)
				privateColumn8 = value
			End Set
		End Property
		Private privateColumn9 As String
		Public Property Column9() As String
			Get
				Return privateColumn9
			End Get
			Set(ByVal value As String)
				privateColumn9 = value
			End Set
		End Property
		Private privateColumn10 As String
		Public Property Column10() As String
			Get
				Return privateColumn10
			End Get
			Set(ByVal value As String)
				privateColumn10 = value
			End Set
		End Property
		Private privateColumn11 As String
		Public Property Column11() As String
			Get
				Return privateColumn11
			End Get
			Set(ByVal value As String)
				privateColumn11 = value
			End Set
		End Property
		Private privateColumn12 As String
		Public Property Column12() As String
			Get
				Return privateColumn12
			End Get
			Set(ByVal value As String)
				privateColumn12 = value
			End Set
		End Property
		Private privateColumn13 As String
		Public Property Column13() As String
			Get
				Return privateColumn13
			End Get
			Set(ByVal value As String)
				privateColumn13 = value
			End Set
		End Property
		Private privateColumn14 As String
		Public Property Column14() As String
			Get
				Return privateColumn14
			End Get
			Set(ByVal value As String)
				privateColumn14 = value
			End Set
		End Property
		Private privateColumn15 As String
		Public Property Column15() As String
			Get
				Return privateColumn15
			End Get
			Set(ByVal value As String)
				privateColumn15 = value
			End Set
		End Property
		Private privateColumn16 As String
		Public Property Column16() As String
			Get
				Return privateColumn16
			End Get
			Set(ByVal value As String)
				privateColumn16 = value
			End Set
		End Property
	End Class
End Namespace
