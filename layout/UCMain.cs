using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace layout
{
    public partial class UCMain : UserControl
    {
        GroupBox gb_left;//左加热块
        GroupBox gb_right;//右加热块

        TableLayoutPanel tlpMain;//整体的表格
        TableLayoutPanel tlpLeft;//左加热块表
        TableLayoutPanel tlpRight;//右加热块表
        public UCMain()
        {
            InitializeComponent();
            int leftrows = 5;
            int rightrows = 5;
            InitUI(leftrows, rightrows);
        }
        private void InitUI(int leftBlockCount, int rightBlockCount)
        {
            FillMainUI();
            FillButtonToTable(leftBlockCount, leftBlockCount, ref tlpLeft, gb_left);
            FillButtonToTable(rightBlockCount, rightBlockCount, ref tlpRight, gb_right);
            foreach (Control control in tlpLeft.Controls)
            {
                if (control is RoundButton)
                {
                    control.BackColor = Color.Red;
                }
            }
            foreach (Control control in tlpRight.Controls)
            {
                if (control is RoundButton)
                {
                    control.BackColor = Color.Red;
                }
            }
        }
        private void FillMainUI()
        {
            tlpMain = new TableLayoutPanel();
            tlpMain.Dock = DockStyle.Fill;
            this.Controls.Add(tlpMain);
            DynamicLayout(tlpMain, 2, 2);//2行2列

            gb_left = new GroupBox();
            gb_left.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gb_left.Text = "左加热块";
            gb_left.Dock = DockStyle.Fill;
            tlpMain.Controls.Add(gb_left);
            tlpMain.SetRow(gb_left, 0);
            tlpMain.SetColumn(gb_left, 0);

            gb_right = new GroupBox();
            gb_right.Text = "右加热块";
            gb_right.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gb_right.Dock = DockStyle.Fill;
            tlpMain.Controls.Add(gb_right);
            tlpMain.SetRow(gb_right, 0);
            tlpMain.SetColumn(gb_right, 1);
        }
        private void DynamicLayout(TableLayoutPanel layoutPanel, int row, int col)
        {
            layoutPanel.AutoSize = true;
            layoutPanel.RowStyles.Clear();
            layoutPanel.ColumnStyles.Clear();

            layoutPanel.RowCount = row;    //设置分成几行
            for (int i = 0; i < row; i++)
            {
                layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            }
            layoutPanel.ColumnCount = col;    //设置分成几列
            for (int i = 0; i < col; i++)
            {
                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            }
        }
        private void FillButtonToTable(int row, int col, ref TableLayoutPanel tlp, GroupBox groupBox)
        {
            tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            groupBox.Controls.Add(tlp);

            DynamicLayout(tlp, row, col);
            int index = 1;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //Button btn = new Button();
                    RoundButton btn = new RoundButton(60);
                    btn.Enabled = false;
                    //btn.Size = new System.Drawing.Size(50, 486);
                    btn.Text = string.Format("{0}", index);
                    tlp.Controls.Add(btn);
                    tlp.SetRow(btn, i);
                    tlp.SetColumn(btn, j);
                    index++;
                }
            }
        }
    }
}
