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

namespace delegateUI
{
    public partial class Form1 : Form
    {
        Myevent myevent;
        public Form1()
        {
            InitializeComponent();
            myevent = new Myevent();
            myevent.StopRun += new Myevent.StopRunEvent(Stop);
        }
        private void Stop()
        {
            MessageBox.Show("Stop");
            textBox2.AppendText("stop");
        }
        private void DoWork1()
        {

            this.Invoke(new Action(() =>
            {
                textBox1.Text = "DoWork1";
            }));
        }
        private delegate void ShowMessageDelegate();
        ShowMessageDelegate showMessageDelegate;
        private void ShowMessage()
        {

            textBox1.Text = "DoWork2";
        }
        private void DoWork2()
        {
            this.Invoke(showMessageDelegate);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(DoWork1);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showMessageDelegate = new ShowMessageDelegate(ShowMessage);
            Thread thread = new Thread(DoWork2);
            thread.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            myevent.Stop();
        }
        //声明 命名委托  无返回值
        delegate void MsgHandler(string txt);
        //执行方法
        private void MsgShow(string txt)
        {
            //和正常使用一样
            richTextBox1.AppendText(txt + "\r\n");
        }
        void Start()
        {
            //命名方法实例化
            MsgHandler msgdele = new MsgHandler(MsgShow);

            //使用命名方法
            //msgdele("命名方法");             //线程内调用
            richTextBox1.Invoke(msgdele, "命名方法");   //线程外调用

            //匿名方法  委托类型  委托变量 = delegate （【参数列表】）{代码块}；
            MsgHandler msgdels = delegate (string txt)
            {
                MsgShow(txt);
            };


            //线程内调用
            //msgdels("匿名方法");

            //线程外调用
            richTextBox1.Invoke(msgdele, "匿名方法");


            //lambda 声明方法
            MsgHandler msglambda = p => { MsgShow(p); };
            //msglambda("lambda");

            //线程外调用
            richTextBox1.Invoke(msglambda, "lambda");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //将方法放到线程中
            Thread trd = new Thread(new ThreadStart(Start));
            trd.Start();
        }
    }
}
