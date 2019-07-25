using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinDbg
{

    class Program
    {
        private static List<User> list = new List<User>();
        static void Main(string[] args)
        {
            MemeryLeakProc();

            Console.ReadLine();
        }
        private static void MemeryLeakProc()
        {
            string str = "aaa";
            while (true)
            {
                for (int i = 0; i < 100 * 1024; i++)
                {
                    str += "bbb" + i;

                    User u = new User();
                    u.Age = i;

                    u.Name = "UserName" + i;

                    list.Add(u);

                }
                Thread.Sleep(1000);

            }

        }
    }
    public class User

    {
        public int Age { set; get; }

        public string Name { set; get; }

    }
}
