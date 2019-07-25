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
using System.Windows.Threading;

namespace bingfaTest
{
    public partial class Form1 : Form
    {
        private int maxThread = 500;
        private List<TestTask> taskList;
        private int sleepTime = 50;
        private bool isWorking = false;
        private DateTime startTime;
        private int counter;
        /// <summary>
        /// 初始化对象列表
        /// </summary>
        private void InitTaskList()
        {
            taskList = new List<TestTask>();
            for (int i = 0; i < maxThread; i++)
            {
                taskList.Add(new TestTask(i));
            }
        }

        /// <summary>
        /// 初始化测试开始前的数据环境
        /// </summary>
        private void InitData()
        {
            isWorking = true;
            startTime = DateTime.Now;
            counter = 0;
        }

        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 显示测试信息
        /// </summary>
        /// <param name="id">线程ID</param>
        /// <param name="time">随机出的时间</param>
        private void ShowInfo(int id, int time)
        {
            var ts = DateTime.Now - startTime;
            var cps = counter / ts.TotalSeconds;

            this.BeginInvoke(
    new Action(() => InfoText.Text =
    $"[共运行{ts.TotalSeconds}秒，每秒接收 {cps} 次]  线程{id}收到{time}!\n"));

        }

        //线程函数
        private void ThreadFunction(object o)
        {
            var t = o as TestTask;
            while (isWorking)
            {
                var time = t.ReceiveData();
                counter++;
                if (time != -1)
                {
                    ShowInfo(t.TaskID, time);
                }
                Thread.Sleep(sleepTime);
            }
        }
        //普通线程的并发按钮
        private void button1_Click(object sender, EventArgs e)
        {
            InitData();
            for (int i = 0; i < maxThread; i++)
            {
                var task = new TestTask(i);
                new Thread(ThreadFunction)
                { IsBackground = true }
                .Start(task);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isWorking = false;
        }
        /// <summary>
        /// 用foreach轮询
        /// </summary>
        private void ThreadPoolFunction()
        {
            while (isWorking)
            {
                foreach (var task in taskList)
                {
                    ThreadPool.QueueUserWorkItem((s =>
                    {
                        counter++;
                        var time = task.ReceiveData();
                        if (time != -1)
                        {
                            ShowInfo(task.TaskID, time);
                        }
                    }));
                }
                Thread.Sleep(sleepTime);
            }
        }

        /// <summary>
        /// 用for轮询
        /// </summary>
        private void ThreadPoolFunction2()
        {
            while (isWorking)
            {
                for (int i = 0; i < taskList.Count; i++)
                {
                    ThreadPool.QueueUserWorkItem((s =>
                    {
                        int index = (int)s;
                        var task = taskList[index];
                        var time = task.ReceiveData();
                        counter++;
                        if (time != -1)
                        {
                            ShowInfo(task.TaskID, time);
                        }
                    }), i);
                }
                Thread.Sleep(sleepTime);
            }
        }
        //线程池并发按钮
        /*使用ThreadPool轮询并发

方法是使用一个List（或其他容器）把所有的对象放进去，
创建一个线程（为了防止UI假死，由于这个线程创建后会一直执行切运算密集，所以使用TheadPool和Thread差别不大），
在这个线程中使用foreach(或for)循环依次对每个对象执行ReceiveData方法，
每次执行的时候创建一个线程池线程来执行*/
        private void button6_Click(object sender, EventArgs e)
        {
            InitData();
            InitTaskList();
            new Thread(ThreadPoolFunction)
            { IsBackground = true }.Start();
        }
        //Task轮询并发按钮
        /*使用Task轮询并发

方法与ThreadPool类似，只是每次创建线程池线程执行ReceiveData方法时是通过Task创建的线程*/
        private void button2_Click(object sender, EventArgs e)
        {
            InitData();
            InitTaskList();

            new Thread(TaskFunction)
            { IsBackground = true }.Start();
        }

        private void TaskFunction()
        {
            while (isWorking)
            {
                foreach (var task in taskList)
                {
                    Task.Run(new Action(() => {
                        var time = task.ReceiveData();
                        counter++;
                        if (time != -1)
                        {
                            ShowInfo(task.TaskID, time);
                        }
                    }));
                }
                Thread.Sleep(sleepTime);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitData();
            InitTaskList();
            new Thread(ParallelFunction2)
            { IsBackground = true }.Start();
        }
        /// <summary>
        /// 使用Parallel.ForEach()并发
        /// </summary>
        private void ParallelFunction()
        {
            while (isWorking)
            {
                Parallel.ForEach(taskList, new Action<TestTask>(task =>
                {
                    var time = task.ReceiveData();

                    if (time != -1)
                    {
                        ShowInfo(task.TaskID, time);
                    }
                }));
                Thread.Sleep(sleepTime);
            }
        }

        /// <summary>
        /// 使用Parallel.For()并发
        /// </summary>
        private void ParallelFunction2()
        {
            while (isWorking)
            {
                Parallel.For(0, taskList.Count, new Action<int>(i => {
                    var task = taskList[i];
                    var time = task.ReceiveData();
                    counter++;
                    if (time != -1)
                    {
                        ShowInfo(task.TaskID, time);
                    }
                }));
                Thread.Sleep(sleepTime);
            }
        }
        /*0x05 使用await轮询并发

方法与ThreadPool类似，只是每次创建线程池线程执行ReceiveData方法时是通过await等待操作。代码如下：

刚开始在foreach中写了await导致线程阻塞，但因为ReceiveData()中测试时为了尽量拉开差距没有让线程睡眠以模拟线程操作，导致没有意识到这个问题，多谢 @逸风之狐 提醒。

修改后代码如下所示，这样测试方法就可以立即返回了。不过async/await确实不是用来干这个的。*/
        private void button5_Click(object sender, EventArgs e)
        {
            InitData();
            InitTaskList();

            new Thread(AwaitFunction)
            { IsBackground = true }.Start();
        }

        /// <summary>
        /// await轮询
        /// </summary>
        private void AwaitFunction()
        {
            while (isWorking)
            {
                foreach (var task in taskList)
                {
                    ReceiveDataAsync(task);
                }
                Thread.Sleep(sleepTime);
            }
        }

        private async void ReceiveDataAsync(TestTask task)
        {
            var t = new Task<int>(task.ReceiveData);
            t.Start();
            var time = await t;
            counter++;
            if (time != -1)
            {
                ShowInfo(task.TaskID, time);
            }
        }
        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = index.ToString();
            index++;
        }
        private void Out()
        {
            textBox2.Text = index.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            isWorking = true;
            new Thread(o =>
            {
                while(isWorking)
                {
                    this.Invoke(new Action(() =>
                    {
                        textBox2.Text = index.ToString();
                    }));

                    this.Invoke(new Action(delegate
                    {
                        textBox3.Text = index.ToString();
                    }));
                }

            })
            { IsBackground = true }.Start();
        }
    }
}
