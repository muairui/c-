using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int q = 0; q < 100000; q++)
            {
                textBox1.Text = q.ToString();
                Application.DoEvents();
            }
            stopWatch.Stop();
            label1.Text = stopWatch.Elapsed.ToString();//计算耗时

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int q = 0; q < 100000; q++)
            {
                textBox2.Text = q.ToString();
            }
            stopWatch.Stop();
            label2.Text = stopWatch.Elapsed.ToString();//计算耗时

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "MainThread";       //主线程命名为 MainThread
            Thread td = new Thread(threadRun);
            td.Name = "ChildThread";                        //子线程命名为 ChildThread
            td.Start();
        }
        private void ChangeText()
        {
            this.textBox1.Text = Thread.CurrentThread.Name; //TextBox1内容被修改的线程的名字
        }

        private void threadRun()
        {
            MessageBox.Show(Thread.CurrentThread.Name);     //弹出对话框, 当前运行线程的名字
            MethodInvoker In = new MethodInvoker(ChangeText);
            this.BeginInvoke(In);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["form1"];
            if (form == null)
            {
                form = new Form1();
            }

            form.Show();
            form.BringToFront();
        }
    }
}
