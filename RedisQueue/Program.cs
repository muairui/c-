using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServiceStack.Redis;
namespace RedisQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(run);
            thread.Start();
            Thread.Sleep(1000);
            Thread[] threads = new Thread[10];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Pull);
                threads[i].Start();
            }

            Console.Read();
        }
        private static void Pull()
        {
            var client = new RedisClient("127.0.0.1", 6379);
            //client.Password = "wolfy";
            while (true)
            {
                if (client.GetListCount("Myqueue") > 0)
                {
                    string result = client.DequeueItemFromList("Myqueue");
                    //如果获取的内容为空，将当前线程挂起1s
                    if (string.IsNullOrEmpty(result))
                    {
                        Thread.SpinWait(1000);
                    }
                    else
                    {
                        Console.WriteLine("Threadid:" + Thread.CurrentThread.ManagedThreadId.ToString() + "\t" + result);
                    }
                }
                else
                {
                    //如果当前队列为空，挂起1s
                    Thread.SpinWait(1000);
                }
            }
        }
        private static void run()
        {
            var client = new RedisClient("127.0.0.1", 6379);
            //client.Password = "wolfy";
            while (true)
            {
                client.EnqueueItemOnList("Myqueue", DateTime.Now.ToString());
            }

        }
    }
}
