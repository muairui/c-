using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefOut
{
    class Program
    {
        static void SwapMethod(ref int a, ref int b)
        {
            int tem;
            tem = a;
            a = b;
            b = tem;
        }

        static void OutTest(out int a)
        {
            a = 10 * 10;
        }
        class Person
        {
            int age;
            string name;
            public Person(int age,string name)
            {
                this.age = age;
                this.name = name;
            }
        }
        static void FillList( List<Person> list)
        {
            list.Add(new Person(1,"name1"));
            list.Add(new Person(2, "name2"));
            list.Add(new Person(3, "name3"));
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;
            int c;
            SwapMethod(ref a, ref b);

            Console.WriteLine(" After Swap a is {0},b is {1} ", a, b);

            OutTest(out c);
            List<Person> list = new List<Person>();
            FillList( list);
            int lenth = list.Count;
            Console.WriteLine("The out value is {0}.", c);
        }
    }
}
