using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // musi to byt zavolano 2x
            Test(this.gridView1, gridView1.Columns[3]);
            Test(this.gridView1, gridView1.Columns[3]);
        }


        private void Test(GridView view, GridColumn column)
        {
            GridViewInfo viewInfo = (GridViewInfo)view.GetViewInfo();
            int leftCoord = viewInfo.GetColumnLeftCoord(column);
            view.LeftCoord = leftCoord;
        }

    }
}
