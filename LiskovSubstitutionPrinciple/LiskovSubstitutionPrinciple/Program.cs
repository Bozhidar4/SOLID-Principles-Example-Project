using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "John";
            accountingVP.LastName = "Smith";
            accountingVP.CalculatePerHourRate(4);

            IManaged employee = new Employee();

            employee.FirstName = "Natasha";
            employee.LastName = "Bears";
            employee.AssignManager(accountingVP);
            employee.CalculatePerHourRate(2);

            Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour.");

            Console.ReadLine();
        }
    }
}
