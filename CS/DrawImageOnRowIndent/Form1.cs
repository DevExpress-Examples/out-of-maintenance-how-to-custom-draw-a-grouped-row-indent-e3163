using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace DrawImageOnRowIndent
{
    public partial class Form1 : Form
    {
        DataTable dt;
        GridIconPainter IconPainter;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Data");
            dt.Columns.Add("Group1");
            dt.Columns.Add("Group2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Rows.Add("data 1", 1, 1);
            dt.Rows.Add("data 2", 1, 2);
            dt.Rows.Add("data 3", 1, 1);
            dt.Rows.Add("data 4", 2, 2);
            dt.Rows.Add("data 5", 2, 1);
            dt.Rows.Add("data 6", 3, 2);
            dt.Rows.Add("data 7", 3, 1);
            dt.Rows.Add("data 8", 4, 2);
            gridControl1.DataSource = dt;
            IconPainter = new GridIconPainter(gridView1);

            IconPainter.RowIcons.Add(0, Properties.Resources.Icon1);
            IconPainter.RowIcons.Add(2, Properties.Resources.Icon2);
            IconPainter.RowIcons.Add(4, Properties.Resources.Icon1);
            IconPainter.RowIcons.Add(5, Properties.Resources.Icon2);
            IconPainter.RowIcons.Add(7, Properties.Resources.Icon1);
        }
    }
}
