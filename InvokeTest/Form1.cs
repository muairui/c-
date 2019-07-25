using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace InvokeTest
{
    public partial class Form1 : Form
    {
        public delegate void invokeDelegate();

        Thread invokeThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString() + "AAA");
            invokeThread = new Thread(new ThreadStart(StartMethod));
            invokeThread.Start();
            string a = string.Empty;
            for (int i = 0; i < 3; i++)      //调整循环次数，看的会更清楚
            {
                Thread.Sleep(1000);
                a = a + "B";
            }
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString() + a);
        }
        private void StartMethod()
        {
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString() + "CCC");
            button1.Invoke(new invokeDelegate(invokeMethod));
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString() + "DDD");
        }

        private void invokeMethod()
        {
            //Thread.Sleep(3000);
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString() + "EEE");
        }
        private void Test()
        {
            MessageBox.Show("test");
        }
    }
}
