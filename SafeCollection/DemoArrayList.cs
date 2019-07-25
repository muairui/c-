using System;
using System.Collections;
using System.Threading;

namespace SafeCollection
{

    public class DemoArrayList
    {
        ArrayList list = new ArrayList(1000000);
        public DemoArrayList()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task2));
        }

        public void Task1(object obj)
        {
            lock (list.SyncRoot)

            {
                for (int i = 0; i < 500000; i++)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Task1 count {0}", list.Count);
        }

        public void Task2(object obj)
        {
            lock (list.SyncRoot)
            {
                for (int i = 0; i < 500000; i++)
                {
                    list.Add(i);
                }
            }
            Console.WriteLine("Task2 count {0}", list.Count);
        }
    }

}