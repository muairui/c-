using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeCollection
{
    class Program
    {
        private static void ConcurrentBagWithPallel()
        {
            List<int> list = new List<int>();
            
           // ConcurrentBag<int> list = new ConcurrentBag<int>();
            Parallel.For(0, 10000, item =>
            {
                list.Add(item);
            });
            Console.WriteLine("ConcurrentBag's count is {0}", list.Count());
            int n = 0;
            foreach (int i in list)
            {
                if (n > 10)
                    break;
                n++;
                Console.WriteLine("Item[{0}] = {1}", n, i);
            }
            Console.WriteLine("ConcurrentBag's max item is {0}", list.Max());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ConcurrentBagWithPallel is runing");
            ConcurrentBagWithPallel();

            DemoArrayList list = new DemoArrayList();
            Console.Read();

        }
    }
}
