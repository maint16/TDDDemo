using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace PolymorphismTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e= new Employee();

            string expectedResponse = $"This Angry employee worked {weeklyHours} hrs." +
                                      $"Paid for 40 hrs at $ {wage} " +
                                      $"/hr  = ${salary}";

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursReturns3850Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor e = new Contractor();

            string expectedResponse = $" This happy contractor worked {weeklyHours} hrs" +
                                      $"Paid for {weeklyHours} hrs at $ {wage}" +
                                      $"/hr = ${salary}";

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursDoesNotReturnCorrectString()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();

            string expectedResponse = $"Problem 1 This Angry employee worked {weeklyHours} hrs." +
                                      $"Paid for 40 hrs at $ {wage} " +
                                      $"/hr  = ${salary}";

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);

        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursDoesNotReturnCorrectString()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Contractor e = new Contractor();

            string expectedResponse = $"Problem 2 This happy contractor worked {weeklyHours} hrs" +
                                      $"Paid for {weeklyHours} hrs at $ {wage}" +
                                      $"/hr = ${salary}";

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);

        }
    }
}
