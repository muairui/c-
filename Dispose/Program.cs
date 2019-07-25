using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class Program
    {
        private static int Cnt = 100000;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //for (int i = 0; i < Cnt; i++)
            // {
            //    IDisposeDerived de = new IDisposeDerived();
            // }
             sw.Stop();
             Console.WriteLine("total time is: " + sw.ElapsedMilliseconds);
             Console.ReadLine();
        }
    }
}
