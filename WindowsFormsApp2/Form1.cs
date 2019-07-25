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

namespace WindowsFormsApp2
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        public class person
        {
            // Bindable property will be created from this property.
            public  string Title { get; set; }
            public int Age { get; set; }

            public List<int> Columns { get; set; }

        }

        public person viewModel { get; set; }
        StatusDelegate status = new StatusDelegate();
        public Form1()
        {
            InitializeComponent();
            mvvmContext1.ViewModelType = typeof(person);
            // Data binding for the Title property (via MVVMContext API)
            mvvmContext1.SetBinding(textEdit1, c => c.EditValue, "Title");
            viewModel  = mvvmContext1.GetViewModel<person>();

            Application.Idle += new EventHandler(OnApplicationIdle);
            status.ShowEvent += new StatusDelegate.ShowDel(CallShow);
        }
        int num = 0;
        private void OnApplicationIdle(object sender, EventArgs e)
        {
            label2.Text = (num++).ToString();
            Thread.Sleep(500);
        }

        private void CallShow()
        {
            this.BeginInvoke(new Action(() => label1.Text = "CallShow"));
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textEdit2.Text = viewModel.Title;
            // UI binding for the Report command
        }
        private void ThreadStart()
        {
            
            this.BeginInvoke(new Action(()=>
                {
                    textEdit2.Text = "ThreadStart";
                 }
                ));
        }
        private void Start()
        {
            textEdit2.Text = "Start";
        }

        private void MethodInvokeStart()
        {
            MethodInvoker methodInvoker = new MethodInvoker(Start);
            this.BeginInvoke(methodInvoker);
        }
        private List<int> Fill1()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            return list;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            viewModel.Title = "test";

            Thread thread = new Thread(MethodInvokeStart);
            thread.Start();
            List<int> list = new List<int>();
        }
        private void StartAction()
        {
            this.BeginInvoke(new Action(() => label1.Text = "tesatatat"));

        }
        private void test()
        {
            Thread thread = new Thread(StartAction);
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test();
        }
        private void CallShowThread()
        {
            //status.CallShow();
            for (int q = 0; q < 10; q++)
            {
                int n = 0;
                Thread.Sleep(1000);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(CallShowThread);
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int q = 0; q < 50000; q++)
            {
                textBox1.Text = q.ToString();
                //Application.DoEvents();//实时响应文本框中的值
            }
            Thread.Sleep(1000);
            for (int q = 0; q < 50000; q++)
            {
                textBox2.Text = q.ToString();
                //Application.DoEvents();//实时响应文本框中的值
            }
        }



    }
}
