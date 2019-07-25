using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DataGridViewRolloverCellColumn col =
                new DataGridViewRolloverCellColumn();
            dataGridView1.Columns.Add(col);
            dataGridView1.Rows.Add(new string[] { "1" });
            dataGridView1.Rows.Add(new string[] { "2" });
            dataGridView1.Rows.Add(new string[] { "3" });
            dataGridView1.Rows.Add(new string[] { "4" });
        }
    }
    public class DataGridViewRolloverCell : DataGridViewTextBoxCell
    {
        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // Call the base class method to paint the default cell appearance.
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
                value, formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts);

            // Retrieve the client location of the mouse pointer.
            Point cursorPosition =
                this.DataGridView.PointToClient(Cursor.Position);

            // If the mouse pointer is over the current cell, draw a custom border.
            if (cellBounds.Contains(cursorPosition))
            {
                Rectangle newRect = new Rectangle(cellBounds.X + 1,
                    cellBounds.Y + 1, cellBounds.Width - 4,
                    cellBounds.Height - 4);
                graphics.DrawRectangle(Pens.Red, newRect);
            }
        }

        // Force the cell to repaint itself when the mouse pointer enters it.
        protected override void OnMouseEnter(int rowIndex)
        {
            this.DataGridView.InvalidateCell(this);
        }

        // Force the cell to repaint itself when the mouse pointer leaves it.
        protected override void OnMouseLeave(int rowIndex)
        {
            this.DataGridView.InvalidateCell(this);
        }

    }

    public class DataGridViewRolloverCellColumn : DataGridViewColumn
    {
        public DataGridViewRolloverCellColumn()
        {
            this.CellTemplate = new DataGridViewRolloverCell();
        }
    }
}
