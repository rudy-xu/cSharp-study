using System;
using Xunit;
using MyMath;

namespace MyMathTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0,2,2)]
        [InlineData(1,2,3)]
        [InlineData(-1,2,1)]
        [InlineData(-1,-2,-3)]
        public void Test1(int a, int b, int excepted)
        {
            Assert.True(NumberCalculation.add(a,b)==excepted, $"{a} + {b} Should be {excepted}");
        }

        // [Fact]
        // public void Test1()
        // {
        //     Assert.True(NumberCalculation.add(0,2) == 2, "0 + 2 should 2");
        // }

        // [Fact]
        // public void Test2()
        // {
        //     Assert.True(NumberCalculation.add(1,2)==3, "1 + 2 Should be 3");
        // }

        // [Fact]
        // public void Test3()
        // {
        //     Assert.True(NumberCalculation.add(-1,2)==1, "-1 + 2 Should be 1");
        // }

        // [Fact]
        // public void Test4()
        // {
        //     Assert.True(NumberCalculation.add(-1,-2)==-3, "-1 + -2 Should be -3");
        // }
    }
}
