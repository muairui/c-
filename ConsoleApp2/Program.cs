using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            heater.Register(new Screen());
            heater.Register(new Alarm());
            heater.GetMonitoring();
        }
    }
}
