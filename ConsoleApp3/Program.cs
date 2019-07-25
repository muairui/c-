using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ConsoleApp3
{

    class MyState
    {
        public int ThreadId = 0;
        public int Data = 0;

        public MyState()
        {

        }
    }
    class AsyncInvoke
    {
        private MyState State = null;

        public AsyncInvoke()
        {
            State = new MyState();
        }

        private int TakesAWhile(int data, int ms)
        {
            Console.WriteLine("TakesAWhile started");
            Thread.Sleep(ms);
            Console.WriteLine("TakesAWhile completed");
            return ++data;
        }

        public delegate int TakesAWhileDelegate(int data, int ms);

        public void RunEndInvoke()
        {
            TakesAWhileDelegate dl = new TakesAWhileDelegate(TakesAWhile);
            IAsyncResult ar = dl.BeginInvoke(5, 3000, null, null);
            int result = 0;
            while (!ar.IsCompleted)//判断委托函数结束 || ar.AsyncWaitHandle.WaitOne(100,false)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            result = dl.EndInvoke(ar);
            Console.WriteLine(string.Format("Result: {0}", result));

        }
    } 
    class Program
    {
        private static void ThreadStart()
        {
            Console.Write("ThreadStart");
            AsyncInvoke asyncInvoke = new AsyncInvoke();
            asyncInvoke.RunEndInvoke();
        }
        static void Main(string[] args)
        {
            A a = new A();
            C c = new C(a);
            a.raise("zuo");
            a.Fail();
            Thread thread = new Thread(ThreadStart);
            thread.Start();
            //Console.ReadLine();

            Console.ReadLine();

        }
    }
    public delegate void HandEventHandler(string hand);
    public delegate void FailEventHandler();
    public class A
    {
        public event HandEventHandler HandEvent;
        public event FailEventHandler FailEvent;

        public void raise(string hand)
        {
            if (HandEvent != null)
            {
                HandEvent(hand);
            }
        }
        public void Fail()
        {
            if (FailEvent != null )
            {
                FailEvent();
            }
        }
    }

    public class B
    {
        void attack()
        {
            Console.Write("B");
        }
    }
    public class C
    {
        public C(A a)
        {
            a.HandEvent += new HandEventHandler(Method);
            a.FailEvent += new FailEventHandler(Fail);
        }
        private void Fail()
        {
            attack();
        }
        private void Method(string hand)
        {
            if (hand.Equals("zuo"))
            {
                attack();
            }
        }
        void attack()
        {
            Console.Write("C");
        }
    }
}
