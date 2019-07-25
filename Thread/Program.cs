using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class4();
            Console.Read();
        }


        private static void Class1()
        {
            Thread thread = new Thread(Run1);
            thread.Start();
            thread.Join();
            Console.WriteLine("我是主线程:" + Thread.CurrentThread.GetHashCode());
        }
        public static void Run1()
        {
            //等待5s
         Thread.Sleep(5000);
         Console.WriteLine("我是线程：" + Thread.CurrentThread.GetHashCode());
        }

        private static void Class2()
        {
            for(int i = 0;i<10;i++)
            {
                Thread t = new Thread(Run2);
                t.Start();
            }
        }
        static object obj = new object();
        static int count = 0;
        static void Run2()
        {

            Thread.Sleep(20);
            Monitor.Enter(obj);
            Console.WriteLine("当前数字：{0}", ++count);
            Monitor.Exit(obj);
        }

        private static void Class3()
        {
            Thread t = new Thread(Run3);
            t.Start();
        }
        /// <summary>
        /// 当给mutex取名的时候能够实现进程同步，不取名实现线程同步
        /// </summary>
        static Mutex mutex = new Mutex(false, "muwm");
        private static void Run3()
        {
            mutex.WaitOne();
            Console.WriteLine("当前时间：{0}我是线程:{1}，我已经进去临界区", DateTime.Now, Thread.CurrentThread.GetHashCode());
            //10s
             Thread.Sleep(10000);

             Console.WriteLine("\n当前时间:{0}我是线程:{1}，我准备退出临界区", DateTime.Now, Thread.CurrentThread.GetHashCode());
             mutex.ReleaseMutex();
        }

        /// <summary>
        /// Interlocked 原子操作，不可分，也就是所谓的无锁编程
        /// </summary>
        private static void Class4()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread t = new Thread(Run4);

                t.Start();
            }
        }
        private static void Run4()
        {
            Thread.Sleep(100);
            //Console.WriteLine("当前数字：{0}", count++); 不是有序的
            Console.WriteLine("当前数字：{0}", Interlocked.Increment(ref count));
        }
    }
}
