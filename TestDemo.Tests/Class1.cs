using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitDemo;
using Xunit;
namespace TestDemo.Tests
{
    public class Arithmetic_Tests
    {
        [Fact]//需要在测试方法加上特性Fact
        public void Add_Ok()
        {
            Arithmetic arithmetic = new Arithmetic();
            var sum = arithmetic.Add(1, 2);

            Assert.True(sum == 3);//断言验证
        }
    }
}
