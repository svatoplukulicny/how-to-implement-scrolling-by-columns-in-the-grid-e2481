Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication3.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHireDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colExtension = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReportsTo = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.employeesTableAdapter = New WindowsApplication3.nwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.employeesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.LookAndFeel.SkinName = "Money Twins"
			Me.gridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(480, 475)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colEmployeeID, Me.colLastName, Me.colFirstName, Me.colTitle, Me.colTitleOfCourtesy, Me.colBirthDate, Me.colHireDate, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colHomePhone, Me.colExtension, Me.colPhoto, Me.colNotes, Me.colReportsTo})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Visible = True
			Me.colEmployeeID.VisibleIndex = 0
			Me.colEmployeeID.Width = 120
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 1
			Me.colLastName.Width = 120
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 2
			Me.colFirstName.Width = 120
			' 
			' colTitle
			' 
			Me.colTitle.FieldName = "Title"
			Me.colTitle.Name = "colTitle"
			Me.colTitle.Visible = True
			Me.colTitle.VisibleIndex = 3
			Me.colTitle.Width = 120
			' 
			' colTitleOfCourtesy
			' 
			Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
			Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
			Me.colTitleOfCourtesy.Visible = True
			Me.colTitleOfCourtesy.VisibleIndex = 4
			Me.colTitleOfCourtesy.Width = 120
			' 
			' colBirthDate
			' 
			Me.colBirthDate.FieldName = "BirthDate"
			Me.colBirthDate.Name = "colBirthDate"
			Me.colBirthDate.Visible = True
			Me.colBirthDate.VisibleIndex = 5
			Me.colBirthDate.Width = 120
			' 
			' colHireDate
			' 
			Me.colHireDate.FieldName = "HireDate"
			Me.colHireDate.Name = "colHireDate"
			Me.colHireDate.Visible = True
			Me.colHireDate.VisibleIndex = 6
			Me.colHireDate.Width = 120
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.Visible = True
			Me.colAddress.VisibleIndex = 7
			Me.colAddress.Width = 120
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 8
			Me.colCity.Width = 120
			' 
			' colRegion
			' 
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.Visible = True
			Me.colRegion.VisibleIndex = 9
			Me.colRegion.Width = 120
			' 
			' colPostalCode
			' 
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			Me.colPostalCode.Visible = True
			Me.colPostalCode.VisibleIndex = 10
			Me.colPostalCode.Width = 120
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 11
			Me.colCountry.Width = 120
			' 
			' colHomePhone
			' 
			Me.colHomePhone.FieldName = "HomePhone"
			Me.colHomePhone.Name = "colHomePhone"
			Me.colHomePhone.Visible = True
			Me.colHomePhone.VisibleIndex = 12
			Me.colHomePhone.Width = 120
			' 
			' colExtension
			' 
			Me.colExtension.FieldName = "Extension"
			Me.colExtension.Name = "colExtension"
			Me.colExtension.Visible = True
			Me.colExtension.VisibleIndex = 13
			Me.colExtension.Width = 120
			' 
			' colPhoto
			' 
			Me.colPhoto.FieldName = "Photo"
			Me.colPhoto.Name = "colPhoto"
			Me.colPhoto.Visible = True
			Me.colPhoto.VisibleIndex = 14
			Me.colPhoto.Width = 120
			' 
			' colNotes
			' 
			Me.colNotes.FieldName = "Notes"
			Me.colNotes.Name = "colNotes"
			Me.colNotes.Visible = True
			Me.colNotes.VisibleIndex = 15
			Me.colNotes.Width = 120
			' 
			' colReportsTo
			' 
			Me.colReportsTo.FieldName = "ReportsTo"
			Me.colReportsTo.Name = "colReportsTo"
			Me.colReportsTo.Visible = True
			Me.colReportsTo.VisibleIndex = 16
			Me.colReportsTo.Width = 120
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(480, 475)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "ScrollByColumns"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private employeesTableAdapter As WindowsApplication3.nwindDataSetTableAdapters.EmployeesTableAdapter
		Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colHireDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colHomePhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colExtension As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn
		Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
		Private colReportsTo As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

