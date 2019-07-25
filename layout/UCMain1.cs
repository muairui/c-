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
    public partial class UCMain1 : UserControl
    {
        GroupBox gb_left;//左加热块
        GroupBox gb_right;//右加热块
        float DefaultWidth;
        float DefaultHeight;
        public UCMain1(float width, float height)
        {
            InitializeComponent();
            DefaultWidth = width;
            DefaultHeight = height;
            int leftrows = 6;
            int rightrows = 6;
            InitUI(leftrows, rightrows);
        }
        private void InitUI(int leftBlockCount, int rightBlockCount)
        {

        }


        float SH
        {
            get
            {
                return (float)Screen.PrimaryScreen.Bounds.Height / DefaultHeight;
            }
        }
        float SW
        {
            get
            {
                return (float)Screen.PrimaryScreen.Bounds.Width / DefaultWidth;
            }
        }

        public void SetFormSize(Control fm)
        {
            fm.Location = new Point((int)(fm.Location.X * SW), (int)(fm.Location.Y * SH));
            fm.Size = new Size((int)(fm.Size.Width * SW), (int)(fm.Size.Height * SH));
            fm.Font = new Font(fm.Font.Name, fm.Font.Size * SH, fm.Font.Style, fm.Font.Unit, fm.Font.GdiCharSet, fm.Font.GdiVerticalFont);
            if (fm.Controls.Count != 0)
            {
                SetControlSize(fm);
            }
        }

        private void SetControlSize(Control InitC)
        {
            foreach (Control c in InitC.Controls)
            {
                c.Location = new Point((int)(c.Location.X * SW), (int)(c.Location.Y * SH));
                c.Size = new Size((int)(c.Size.Width * SW), (int)(c.Size.Height * SH));
                c.Font = new Font(c.Font.Name, c.Font.Size * SH, c.Font.Style, c.Font.Unit, c.Font.GdiCharSet, c.Font.GdiVerticalFont);
                if (c.Controls.Count != 0)
                {
                    SetControlSize(c);
                }
            }
        }
    }
}
