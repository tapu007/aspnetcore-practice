using System;
using System.Linq;
using EmployeeManagement.Models.DatabaseContext;
using EmployeeManagement.Models.EntityModels;
using EmployeeManagement.Repositories.Repository;

namespace EmployeeManagement.EFExamples
{
    class Program
    {
        static void Main(string[] args)
        { 
          
            EmployeeRepository repository = new EmployeeRepository(); 
           
            var employeeSearchCriteria = new Employee()
            {
                Name="l",
                RegNo = "1",
              
            };

            var retrieveEmployees = repository.Search(employeeSearchCriteria);

            if (!retrieveEmployees.Any())
            {
               Console.WriteLine("Not Found!");
                Console.ReadKey();
                return;
            }


            foreach (var employee in retrieveEmployees)       {
                Console.WriteLine(employee.Name);
            }

            Console.ReadKey();
        }
    }
}
