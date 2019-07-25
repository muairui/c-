using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace yibu
{
    class Program
    {
        public static async Task<int> CalcAsync(int wait, int shit)
        {
            await Task.Run(() => Thread.Sleep(wait));
            Console.WriteLine(shit);
            return shit;
        }
        public static async void TestDoubleTask()
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            Task<int> t1 = CalcAsync(10000, 1); // t1 开始运行 
            Task<int> t2 = CalcAsync(2000, 2); // t2 开始运行 
            Task<int> t3 = CalcAsync(5000, 3); // t2 开始运行 
            int r1 = await t1;
            int r2 = await t2; // 等待 t1, t2 均完成 
            int r3 = await t3;
            t.Stop();
            Console.WriteLine("Using Elapsed output runTime:{0}{1}{2}{3}", t.Elapsed.ToString(), r1, r2,r3);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
        }


        static void Main(string[] args)
        {
            TestDoubleTask();
            /* Thread thread = new Thread(DoWork);
             thread.Start();*/
            Console.ReadLine();
        }
        static void DoWork()
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            Task[] tasks = new Task[3];
            bool result = false;
            bool result1 = false;
            tasks[0] = Task.Factory.StartNew(() => AsyncMethod1(ref result));
            tasks[1] = Task.Factory.StartNew(() => AsyncMethod(ref result1));
            tasks[2] = Task.Factory.StartNew(() => Method(1500));
            Task.WaitAll(tasks);

            Console.WriteLine("完毕");
            t.Stop();
            Console.WriteLine("Using Elapsed output runTime:{0}{1}{2}", t.Elapsed.ToString(), result, result1);
        }
        static int Test()
        {
            return 0;
        }
        static  void Method(int time)
        {
            Console.WriteLine("开始异步代码Method");
            Thread.Sleep(time);
            Console.WriteLine("异步代码执行完毕Method");
        }

        static  void AsyncMethod1(ref bool result)
        {
            Console.WriteLine("开始异步代码AsyncMethod1");
            Thread.Sleep(5000);
            Console.WriteLine("异步代码执行完毕AsyncMethod1");
            result = true;

        }
        static  void AsyncMethod(ref bool result)
        {
            Console.WriteLine("开始异步代码AsyncMethod");
            Thread.Sleep(5000);
            Console.WriteLine("异步代码执行完毕AsyncMethod");
            result = true;
        }

        static async Task<int> MyMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("异步执行" + i.ToString() + "..");
                await Task.Delay(1000); //模拟耗时操作
            }
            return 0;
        }
    }
}
