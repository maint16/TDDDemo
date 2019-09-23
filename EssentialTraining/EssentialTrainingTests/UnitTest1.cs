using System;
using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculate = new Calculate();
            var testResult = calculate.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "I expect 9+5=14");
        }
    }
}
