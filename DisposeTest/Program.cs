using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Data caryClass = new Data())
            {

                caryClass.DoSomething();

            }


            Data caryClass1 = new Data();
            caryClass1.tag = Tag.Example | Tag.None;
            try
            {
                caryClass1.DoSomething();
            }
            finally
            {
                caryClass1.Dispose();
                IDisposable disposable = caryClass1 as IDisposable;
                if (disposable != null)
                    disposable.Dispose();
            }
        }
    }
    public enum Tag
    {
        None = 0x0,
        Tip = 0x1,
        Example = 0x2
    }

    public class  Data:IDisposable
    {
        public void DoSomething()
        {
            Console.WriteLine("Do some thing....");
        }
        public void Dispose()
        {
            Console.WriteLine("及时释放资源");
        }
        public Tag tag { get; set; }
    }
}
