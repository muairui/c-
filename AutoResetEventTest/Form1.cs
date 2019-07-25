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

namespace AutoResetEventTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);


        private bool Send()
        {
            return autoResetEvent.WaitOne(5000);
        }
        private bool test()
        {
            bool ret = false;
            button1.Enabled = false;
            Task task = Task.Factory.StartNew(() =>
            {
                ret = GetDataFromServer();
            });
            return ret;
        }
        private void Make(out int i )
        {
            i = 100;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("1" + "\r\n");
            //int i;
            Make(out int i);
            button1.Enabled = false;
            bool ret = false;
            int count = 0;
            AutoResetEvent autoResetEvent1 = new AutoResetEvent(false);
            AutoResetEvent autoResetEvent2 = new AutoResetEvent(false);
            Task task = Task.Factory.StartNew(() =>
            {
                ret = Send();
                while(ret == false)
                {
                    count++;
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        textBox1.Text = count.ToString();
                    }));
                    if (count == 3)
                    {
                        MessageBox.Show("chaoshi");
                        return;
                    }
                    ret = Send();
 
                }
            });
            button3.Enabled = ret;

        }
        bool GetDataFromServer()
        {
            //Thread.Sleep(TimeSpan.FromSeconds(4));
            bool ret = autoResetEvent.WaitOne(10000);
            this.BeginInvoke(new MethodInvoker(delegate
            {
                button1.Enabled = true;
                button3.Enabled = ret;
            }));
            if(ret == false)
            {
                MessageBox.Show("chaoshi");
  
            }
            return ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autoResetEvent.Set();
            button1.Enabled = true;
        }
    }
}
