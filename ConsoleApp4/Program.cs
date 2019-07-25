using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog xmfdsh = new MyBlog("xmfdsh", "发布了一篇新博客");

            // 添加订阅者
            xmfdsh.AddObserver(new Subscriber("王尼玛"));
            xmfdsh.AddObserver(new Subscriber("唐马儒"));
            xmfdsh.AddObserver(new Subscriber("王蜜桃"));
            xmfdsh.AddObserver(new Subscriber("敖尼玛"));

            //更新信息
            xmfdsh.Update();
            //输出结果，此时所有的订阅者都已经得到博客的新消息
            Console.ReadLine();
        }
    }
}
