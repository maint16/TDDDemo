using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Polymorphism
{
   public class Program
    {
       private static void Main(string[] args)
       {
           const int hours = 55, wage = 70;
         //  List<Employee> employees = Utils.GetEmployees();

         var mock = new Mock<Utils>();
         mock.Setup(m => m.GetMockEmployees()).Returns(() =>
             new List<Employee>
             {
                 new Contractor(),
                 new Employee()
             });

         List<Employee> employees = mock.Object.GetMockEmployees();
           foreach (var e in employees)
           {
               e.CalculateWeeklySalary(hours, wage);
           }

           Console.ReadLine();
       }

      
    }

   public  class Utils
   {
       //public static List<Employee> GetEmployees()
       //{
       //    var someEmployee = new Employee();
       //    var someContractor = new Contractor();
       //    var everyone = new List<Employee> { someEmployee, someContractor };
       //    return everyone;
       //}

       public virtual List<Employee> GetMockEmployees()
       {
           throw new NotImplementedException();
       }
    }

    public class Employee
    {
        public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            string result = $"This Angry employee worked {weeklyHours} hrs." +
                            $"Paid for 40 hrs at $ {wage} " +
                            $"/hr  = ${salary}";
            Console.WriteLine("\n"+result+"\n");

            Console.WriteLine("----------\n");
            return result;

        }
    }

    public class Contractor : Employee
    {
        public override string CalculateWeeklySalary(int weekyHours, int wage)
        {
            var salary = weekyHours * wage;
            string result = $" This happy contractor worked {weekyHours} hrs" +
                            $"Paid for {weekyHours} hrs at $ {wage}" +
                            $"/hr = ${salary}";
            Console.WriteLine(result);

            Console.WriteLine("------------\n");
            return result;
        }
    }
}
