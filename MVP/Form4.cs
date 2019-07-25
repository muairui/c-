using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace MVP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn column0 =
    new DataGridViewCheckBoxColumn();
            DataGridViewDisableButtonColumn column1 =
                new DataGridViewDisableButtonColumn();
            column0.Name = "CheckBoxes";
            column1.Name = "Buttons";
            dataGridView1.Columns.Add(column0);
            dataGridView1.Columns.Add(column1);
            dataGridView1.RowCount = 8;
            dataGridView1.AutoSize = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Set the text for each button.
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Buttons"].Value =
                    "Button " + i.ToString();
            }

            dataGridView1.CellValueChanged +=
                new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged +=
                new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);
            dataGridView1.CellClick +=
                new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        void dataGridView1_CurrentCellDirtyStateChanged(object sender,
        EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // If a check box cell is clicked, this event handler disables  
        // or enables the button in the same row as the clicked cell.
        public void dataGridView1_CellValueChanged(object sender,
            DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "CheckBoxes")
            {
                DataGridViewDisableButtonCell buttonCell =
                    (DataGridViewDisableButtonCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Buttons"];

                DataGridViewCheckBoxCell checkCell =
                    (DataGridViewCheckBoxCell)dataGridView1.
                    Rows[e.RowIndex].Cells["CheckBoxes"];
                buttonCell.Enabled = !(Boolean)checkCell.Value;

                dataGridView1.Invalidate();
            }
        }

        // If the user clicks on an enabled button cell, this event handler  
        // reports that the button is enabled.
        void dataGridView1_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Buttons")
            {
                DataGridViewDisableButtonCell buttonCell =
                    (DataGridViewDisableButtonCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Buttons"];

                if (buttonCell.Enabled)
                {
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].
                        Cells[e.ColumnIndex].Value.ToString() +
                        " is enabled");
                }
            }
        }

    }
    public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            this.CellTemplate = new DataGridViewDisableButtonCell();
        }
    }

    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        // By default, enable the button cell.
        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // The button cell is disabled, so paint the border,  
            // background, and disabled button for the cell.
            if (!this.enabledValue)
            {
                // Draw the cell background, if specified.
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                // Draw the cell borders, if specified.
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.                
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                // Draw the disabled button text. 
                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        this.DataGridView.Font,
                        buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                // The button cell is enabled, so let the base class 
                // handle the painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }
}
