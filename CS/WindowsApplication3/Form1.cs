using DevExpress.XtraEditors;
using System;


namespace WindowsApplication3
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridHScrollHelper helper = new GridHScrollHelper(gridView1);
            helper.EnableScrollByColumns();
            gridControl1.DataSource = ItemList.GetList();
            gridView1.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
        }
    }
}
