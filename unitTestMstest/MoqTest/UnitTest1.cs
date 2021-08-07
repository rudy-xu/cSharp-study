using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqProject;

namespace MoqTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testMatch = new Mock<IMatchTest>();
            testMatch.Setup(p => p.Test(It.Is<int>(i => i % 2 == 0))).Returns("偶数");
            testMatch.Setup(p => p.Test(It.Is<int>(i => i % 2 != 0))).Returns("奇数");
            Assert.AreEqual("偶数", testMatch.Object.Test(4));
            Assert.AreEqual("奇数", testMatch.Object.Test(3));

            // var mock = new Mock<IGetData>();
            // mock.Setup(p => p.GetNameId(1)).Returns("Jack");
            // HomeControl home = new HomeControl(mock.Object);
            // string res = home.H_GetNameId(1);
            // Assert.AreEqual("Jack",res); 
        }
    }
}
