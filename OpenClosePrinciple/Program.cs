using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "John", LastName = "Michaels"},
                new ManagerModel { FirstName = "Elizabeth", LastName = "Perl"},
                new ExecutiveModel { FirstName = "Bob", LastName = "Richards"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}, IsManager: {employee.IsManager}, IsExecutive: {employee.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
