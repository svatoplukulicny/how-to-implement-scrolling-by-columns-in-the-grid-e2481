Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors


Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
			Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
			Dim helper As New GridHScrollHelper(gridView1)
			helper.EnableScrollByColumns()
		End Sub


	End Class
End Namespace
