using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DrawImageOnRowIndent
{
    class GridIconPainter
    {
        GridControl Grid;
        GridView View;
        public Dictionary<int, Icon> RowIcons;

        public GridIconPainter(GridView view)
        {
            this.View = view;
            this.Grid = view.GridControl;
            Grid.Paint += new System.Windows.Forms.PaintEventHandler(Grid_Paint);
            RowIcons = new Dictionary<int, Icon>();
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            GridViewInfo vi = new GridViewInfo(View);
            vi.Calc(e.Graphics, Grid.Bounds);
            foreach (GridRowInfo row in vi.RowsInfo)
            {
                if (!row.IsGroupRow)
                {
                    if (!RowIcons.ContainsKey(row.RowHandle))
                        continue;
                    Rectangle rec = row.Bounds;
                    int groupX = row.Level * (row.DataBounds.X - row.Bounds.X) / (row.Level + 1);
                    rec.X += groupX;
                    rec.Width -= row.DataBounds.Width;
                    rec.Width -= groupX;
                    e.Graphics.DrawIcon(RowIcons[row.RowHandle], rec);
                }
            }
        }

    }
}
