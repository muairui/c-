using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class RoundButton : Button
    {
        private int radius;//半径 

        //圆形按钮的半径属性
        [CategoryAttribute("布局"), BrowsableAttribute(true), ReadOnlyAttribute(false)]
        public int Radius
        {
            set
            {
                radius = value;
                this.Height = this.Width = Radius;
            }
            get
            {
                return radius;
            }
        }

        private Color foreColorNormal;
        [CategoryAttribute("字体颜色"), BrowsableAttribute(true), ReadOnlyAttribute(false)]
        public Color ForeColorNormal
        {
            set
            {
                foreColorNormal = value;
                ForeColor = foreColorNormal;
            }
            get
            {
                return foreColorNormal;
            }
        }

        private Image imageNormal;
        [CategoryAttribute("外观"), BrowsableAttribute(true), ReadOnlyAttribute(false)]
        public Image ImageNormal
        {
            set
            {
                imageNormal = value;
                BackgroundImage = imageNormal;
            }
            get
            {
                return imageNormal;
            }
        }

        //以下代码用于在VS中隐藏Size属性，使得只能通过Diameter设置Height和Width
        [BrowsableAttribute(false)]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                base.Size = value;

            }
        }

        public RoundButton()
        {
            Radius = 64;
            this.Height = this.Width = Radius;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ForeColor = Color.White;
        }

        //重写OnPaint
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, Radius, Radius);
            this.Region = new Region(path);
        }

        //重写OnSizeChanged
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Height != Radius)
            {
                Radius = Width = Height;
            }
            else if (Width != Radius)
            {
                Radius = Height = Width;
            }

        }
    }
}

