using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEx
{
    public class ControlButton : Button
    {
        public ControlButton()
        {
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(102, 102, 102);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 150, 150);
        }
        private bool _isClicked = false;
        public bool IsClicked
        {
            get { return _isClicked; }
            set { _isClicked = value; }
        }

        private bool _inClient = false;
        private bool _mouseDown = false;

        private bool _enableClicked = false;
        [Category("自定义属性"), Description("启用按下状态")]
        public bool EnableClicked
        {
            get { return _enableClicked; }
            set { _enableClicked = value; }
        }

        private Color _fontColor = Color.Gainsboro;
        [Category("自定义属性"), Description("按下状态字体颜色")]

        public Color ClickedForeColor
        {
            get { return _fontColor; }
            set { _fontColor = value; }
        }

        private Size _imgSize;
        [Category("自定义属性"), Description("图片尺寸")]
        public Size ImageSize
        {
            get { return _imgSize; }
            set
            {
                _imgSize = value;
                Invalidate();
            }
        }

        private Image _enterImage = null;
        [Category("自定义属性"), Description("鼠标悬浮时图片")]

        public Image EnterImage
        {
            get { return _enterImage; }
            set
            {
                _enterImage = value;
            }
        }
        private Image _downImage = null;
        [Category("自定义属性"), Description("鼠标按下时图片")]
        public Image DownImage
        {
            get { return _downImage; }
            set { _downImage = value; }
        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            IsClicked = !IsClicked;
            _mouseDown = true;
            if(_downImage != null)
            {
                this.BackgroundImage = _downImage;
            }
            //base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _mouseDown = false;
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _inClient = true;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _inClient = false;
            base.OnMouseLeave(e);
        }
    }
}
