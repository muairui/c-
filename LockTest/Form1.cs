using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockTest
{
    public partial class Form1 : Form
    {
        public static object locker = new object();//添加一个对象作为锁

        private List<int> list = new List<int>();
        private int count = 0;
        public Form1()
        {
            InitializeComponent();

        }
        Task t;
        Task t1;
        private void button1_Click(object sender, EventArgs e)
        {
            t = new Task(ThreadMethod);
            t1 = new Task(RefershMethod);
            t.Start();
            t1.Start();
        }
        private void RefershMethod()
        {
            while(true)
            {
                MethodInvoker m1 = new MethodInvoker(TextRefresh);
                this.Invoke(m1);
                Thread.Sleep(10);
            }
        }
        private void TextRefresh()
        {
            textBox1.Text = list.Count.ToString();
        }
        private void LabelRefresh()
        {
            label1.Text = count.ToString();
        }
        private void ThreadMethod()
        {
            while(true)
            {
                list.Add(count);
                MethodInvoker m1 = new MethodInvoker(LabelRefresh);
                this.Invoke(m1);
                count++;
                Thread.Sleep(10);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
