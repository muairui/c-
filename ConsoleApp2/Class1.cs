using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Heater:SubjectBase
    {
        private int temp;
        protected virtual void OnBioiled()
        {
            base.Notify(temp);
        }
        public void GetMonitoring()
        {
            for(int i =0;i <=99;i++)
            {
                temp = i + 1;
                if (temp >95)
                {
                    OnBioiled();
                }
            }
        }
    }
    public class Alarm : IObserver
    {
        public void Update(int temp)
        {
            if (temp == 100)
            {
                Console.WriteLine("水烧开了" + temp);
            }
            else
            {
                Console.WriteLine("开始报警，水快烧开了>> " + temp);
            }
        }
    }
    public class Screen : IObserver
    {
        public void Update(int temp)
        {
            if (temp == 100)
            {
                Console.WriteLine("水烧开了" + temp);
            }
            else
            {
                Console.WriteLine("水快烧开了>> " + temp);
            }
        }
    }
}
