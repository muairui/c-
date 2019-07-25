using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen p;
        Graphics g1;
        //绘制带箭头线段
        private void button1_Click(object sender, EventArgs e)
        {

            g1 = this.CreateGraphics();
            g1.Clear(Color.White);
            p = new Pen(Color.YellowGreen, 8);
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.ArrowAnchor;
            g1.DrawLine(p, 150, 150, 500, 200);
        }
        //绘制艺术相框，主用用到了阴影画刷HatchBrush
        private void button2_Click(object sender, EventArgs e)
        {
            g1 = this.CreateGraphics();
            g1.Clear(Color.White);
            g1.FillRectangle(Brushes.LightBlue, this.ClientRectangle);//画板颜色
            HatchBrush hb = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.White, Color.Black);
            p = new Pen(hb, 10);
            g1.DrawRectangle(p, 300, 30, 80, 80);
        }
        //绘制特殊艺术图像 绘制特殊的渐变图形，主要用到GraphicsPath类的AddLines()方法           /// PathGradientBrush路径渐变画刷，PathGradientBrush的CenterColor属性 
        private void button3_Click(object sender, EventArgs e)
        {
            g1 = this.CreateGraphics();
            g1.Clear(Color.White);
            Point[] points = {
                new Point(175, 0), new Point(200, 150), new Point(250, 0), new Point(200, 175),
                new Point(250, 250), new Point(165, 200), new Point(0, 250), new Point(135, 175), new Point(0, 150), new Point(150, 150), new Point(175, 0)
            };
            GraphicsPath gPath = new GraphicsPath();//创建路径            
            gPath.AddLines(points); //在路径中添加直线             
            PathGradientBrush pGradientBrush = new PathGradientBrush(gPath);//路径渐变画刷            
            pGradientBrush.CenterColor = Color.Red;//设置中心点色彩             
            Color[] colors = new Color[]{
                Color.Aqua,Color.Green,
                Color.Blue,Color.White,
                Color.Beige,Color.Green,
                Color.Blue,Color.White,
                Color.Black,Color.Green
            };
            pGradientBrush.SurroundColors = colors;//设置路径渐变画刷边缘色            
            g1.FillPath(pGradientBrush, gPath);  //填充路径
        }
        // 绘制渐变图形主要使用渐变画刷LinearGradientBrush类
        private void button6_Click(object sender, EventArgs e)
        {
            g1 = this.CreateGraphics();
            g1.Clear(Color.White);
            p = new Pen(Color.YellowGreen, 2);
            //LinearGradientBrush渐变画刷，可以实现简单线性渐变效果
            LinearGradientBrush linGrBrush1 = new LinearGradientBrush(new Rectangle(0, 0, 80, 40), Color.Red, Color.Yellow, 30.0f);
            g1.FillRectangle(linGrBrush1, new Rectangle(150, 20, 120, 120));  //填充指定矩形内部
            g1.DrawRectangle(p, new Rectangle(150, 20, 120, 120));
        }
        //绘制数学曲线Graphic.DrawBezier()数学曲线
        private void button5_Click(object sender, EventArgs e)
        {
            g1 = this.CreateGraphics();
            g1.Clear(Color.White);
            p = new Pen(Color.Black, 2);
            //绘制曲线
            g1.DrawBezier(p, new Point(20, 30), new Point(60, 0), new Point(200, 180), new Point(300, 200));
        }
        //缩放图形 Graphics.ScaleTransform()缩放
        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);  //创建图形对象
            Bitmap bmp2 = new Bitmap(pictureBox1.Image);
            g1 = pictureBox2.CreateGraphics();           //创建画板
            g1.Clear(pictureBox2.BackColor);             //清空画板
            float s = Convert.ToSingle(0.5);             //缩放倍数
            g1.ScaleTransform(s, s);                     //缩放 ，图形缩放方法
            //重绘图形
            g1.DrawImage(bmp1, this.pictureBox2.ClientRectangle, 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel);
        }
        //图形的旋转Graphics.RotateTransform()函数
        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox1.Image);
            g1 = pictureBox2.CreateGraphics();
            g1.Clear(pictureBox2.BackColor);
            g1.RotateTransform(30);  //旋转，使图形按照一定角度旋转
            g1.DrawImage(bmp1, this.pictureBox2.ClientRectangle, 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel);
        }
        //图形平移
        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox1.Image);
            g1 = pictureBox2.CreateGraphics();
            g1.Clear(pictureBox2.BackColor);
            float sx = Convert.ToSingle(20);
            float sy = Convert.ToSingle(20);
            g1.TranslateTransform(sx, sy);
            g1.DrawImage(bmp1, this.pictureBox2.ClientRectangle, 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel);

        }
        //通过绘制线条，绘制动画
        private void button8_Click(object sender, EventArgs e)
        {
            g1 = pictureBox2.CreateGraphics();
            g1.Clear(pictureBox2.BackColor);
            Pen p1 = new Pen(Color.Blue);
            p = new Pen(Color.Red);
            int y = 256;
            for (int x = 0; x < 256; x += 5)
            {
                g1.DrawLine(p1, 0, y, x, 0);
                g1.DrawLine(p, 256, x, y, 256);
                y -= 5;
                Thread.Sleep(20);     //线程延迟20毫秒
            }
            for (y = 0; y < 256; y += 5)
            {
                Pen p2 = new Pen(Color.FromArgb(y, Color.Yellow));
                g1.DrawLine(p2, 0, y, 256, y);
                Thread.Sleep(20);
            }

        }
        //图像缩放
        private void button11_Click(object sender, EventArgs e)
        {
            g1 = pictureBox2.CreateGraphics();

            g1.DrawImage(pictureBox1.Image, 80, 30, 150, 150);    //通过绘图方法实现图片的放缩

        }
        //图像旋转Bitmap.RotateFlip()图像旋转方法
        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);//旋转,图像本身的旋转
            pictureBox2.Image = bmp;
        }
    }
}
