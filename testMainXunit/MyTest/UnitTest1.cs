using System;
using Xunit;
using MyProject;

namespace testMainXunit
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0,2,2)]
        [InlineData(5,-2,3)]
        [InlineData(0,0,0)]
        public void Test1(int a, int b, int res)
        {
            Assert.True(MyClass.sum(a,b) == res, $"{a} + {b} Should be {res}");
        }

        // [Fact]
        // public void Test1()
        // {
            
        // }
    }
}
