using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTest
{
    /// <summary>
    /// 深拷贝浅拷贝
    /// 浅复制：在C#中调用 MemberwiseClone() 方法即为浅复制。
    /// 如果字段是值类型的，则对字段执行逐位复制，
    /// 如果字段是引用类型的，则复制对象的引用，而不复制对象，因此：原始对象和其副本引用同一个对象！
    /// 深复制：如果字段是值类型的，则对字段执行逐位复制，如果字段是引用类型的，则把引用类型的对象指向一个全新的对象！
    /// </summary>
    /// 

    class Program
    {

         delegate void CallBack(string name);
        static void Main(string[] args)
        {
            /* Student s1 = new Student("Vivi", 28);
             Console.WriteLine("s1=[" + s1 + "]");
             //Student s2 = (Student)s1.ShallowCopy();
             Student s2 = (Student)s1.DeepCopy(); 
             Console.WriteLine("s2=[" + s2 + "]"); //此处s2和s1内容相同 
             Console.WriteLine("-----------------------------");
             //修改s2的内容 
             s2.Name = "tianyue";
             s2.Age = 25;
             s2.Room.RoomID = 2;
             s2.Room.RoomName = "Room2";
             Console.WriteLine("s1=[" + s1 + "]");
             Console.WriteLine("s2=[" + s2 + "]");
             //再次打印两个对象以比较 


             */
            //创建P1对象

            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1.IdInfo = new IdInfo("081309207");

            //通过浅复制 得到P2对象
            Person p2 = p1.ShallowCopy();
            //分别输出
            Console.WriteLine("对象P1相关属性如下");
            DisplayValues(p1);
            //p1.Name = "";
            //p1.IdInfo.IdNumber = "XXXXX";
            Console.WriteLine("对象P2相关属性如下");
            DisplayValues(p2);

            //现在测试深复制
            Person p3 = p1.DeepCopy();

            p1.Name = "George";
            p1.Age = 39;
            p1.IdInfo.IdNumber = "081309208";
            Console.WriteLine("对象P1相关属性如下");
            DisplayValues(p1);
            //p1.IdInfo.IdNumber = "CCCCCCC";
            Console.WriteLine("对象P3相关属性如下");
            DisplayValues(p3);

            Console.WriteLine("对象P2相关属性如下");
            DisplayValues(p2);
            Console.Read();

            Console.ReadLine();
        }
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);

            CallBack callBack = delegate (string name)
            {
                Console.WriteLine(name);
            };
            callBack("test");
            Add<int>(1, 2);
        }

        public static T Add<T>(T obj1,T obj2 )
        {
            return obj1;
        }
    }
}
