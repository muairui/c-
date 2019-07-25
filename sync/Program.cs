using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sync
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(TestShow));

            Thread thread1 = new Thread(new ThreadStart(TestShow1));

            thread.Start();

            thread1.Start();

            Console.ReadKey();
        }
        static bool biaoJi = false;
        private static readonly object obj = new object();
        static Mutex m = new Mutex();
        static void TestShow()
        {
            //Monitor.Enter(obj);//Lock语句经过编译器解析为Monitor类。Monitor类的效果和Lock基本是一样的
            lock (obj)//Lock关键字将语句块标记为临界区，方法是获取给定对象的互斥锁，执行语句，然后释放该锁
            {
                if (!biaoJi)
                {
                    biaoJi = true;

                    Console.WriteLine("标记为False");
                }
            }
            //Monitor.Exit(obj);

            //Monitor
            /*if(Monitor.TryEnter(obj, 2000))//除此之外Monitor还有一个优点就是可以设置一个等待获得锁定的超时值，用以避免无限期的锁定
            {

                try
                {
                    if (!biaoJi)
                    {
                        biaoJi = true;

                        Console.WriteLine("标记为False");
                    }
                }
                finally
                {
                    Monitor.Exit(obj);
                }

            }*/

            //Mutex的功能和C# 中的Lock一样，不同的是它可以跨进程

           /* m.WaitOne();
            if (!biaoJi)
            {
                biaoJi = true;

                Console.WriteLine("标记为False");
            }
            m.ReleaseMutex();*/


            /*
             * 此外我们还可以为WaitOne（）函数设置参数，以防止无限期的等待。

                Mutex类还有一些其他的方法：比如：

                Mutex的WaitAll()函数//等待所有的线程操作

                Mutex的WaitAny()函数//多个操作时，等待指定的某个线程操作
             */

        }
        static void TestShow1()
        {
            lock(obj)
            {
                if (biaoJi)
                {
                    Console.WriteLine("标记为True");
                }
            }

        }
    }
}
