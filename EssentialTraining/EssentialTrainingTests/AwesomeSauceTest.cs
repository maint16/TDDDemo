using System;
using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobacco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            //Expect to pass
           Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

           // Expect to false
           Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
