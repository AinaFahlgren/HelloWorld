using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HelloWorld
{
    public class NewXUnit
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
    }
}