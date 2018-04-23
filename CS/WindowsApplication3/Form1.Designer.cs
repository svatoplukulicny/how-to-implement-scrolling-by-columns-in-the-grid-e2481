namespace WindowsApplication3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication3.nwindDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitleOfCourtesy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReportsTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeesTableAdapter = new WindowsApplication3.nwindDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employeesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.SkinName = "Money Twins";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(480, 475);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colLastName,
            this.colFirstName,
            this.colTitle,
            this.colTitleOfCourtesy,
            this.colBirthDate,
            this.colHireDate,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colHomePhone,
            this.colExtension,
            this.colPhoto,
            this.colNotes,
            this.colReportsTo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            this.colEmployeeID.Width = 120;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 120;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            this.colFirstName.Width = 120;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 3;
            this.colTitle.Width = 120;
            // 
            // colTitleOfCourtesy
            // 
            this.colTitleOfCourtesy.FieldName = "TitleOfCourtesy";
            this.colTitleOfCourtesy.Name = "colTitleOfCourtesy";
            this.colTitleOfCourtesy.Visible = true;
            this.colTitleOfCourtesy.VisibleIndex = 4;
            this.colTitleOfCourtesy.Width = 120;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 5;
            this.colBirthDate.Width = 120;
            // 
            // colHireDate
            // 
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Visible = true;
            this.colHireDate.VisibleIndex = 6;
            this.colHireDate.Width = 120;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 7;
            this.colAddress.Width = 120;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 8;
            this.colCity.Width = 120;
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.Visible = true;
            this.colRegion.VisibleIndex = 9;
            this.colRegion.Width = 120;
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 10;
            this.colPostalCode.Width = 120;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 11;
            this.colCountry.Width = 120;
            // 
            // colHomePhone
            // 
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.Visible = true;
            this.colHomePhone.VisibleIndex = 12;
            this.colHomePhone.Width = 120;
            // 
            // colExtension
            // 
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 13;
            this.colExtension.Width = 120;
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 14;
            this.colPhoto.Width = 120;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 15;
            this.colNotes.Width = 120;
            // 
            // colReportsTo
            // 
            this.colReportsTo.FieldName = "ReportsTo";
            this.colReportsTo.Name = "colReportsTo";
            this.colReportsTo.Visible = true;
            this.colReportsTo.VisibleIndex = 16;
            this.colReportsTo.Width = 120;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 475);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "ScrollByColumns";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private WindowsApplication3.nwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colTitleOfCourtesy;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colHomePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colReportsTo;
    }
}

