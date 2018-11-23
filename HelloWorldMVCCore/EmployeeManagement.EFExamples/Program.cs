using System;
using System.Linq;
using EmployeeManagement.Models.DatabaseContext;
using EmployeeManagement.Models.EntityModels;

namespace EmployeeManagement.EFExamples
{
    class Program
    {
        static void Main(string[] args)
        { 
            EmployeeDbContext db = new EmployeeDbContext();
            var employee = db.Employees.FirstOrDefault(c => c.Id==3);
            if (employee == null)
            {
                Console.WriteLine("No Employee Found!");
                Console.ReadKey();
                return;
                
            }

            Console.WriteLine(employee.GetInfo());

            Console.WriteLine("Please provide new Name:");
            employee.Name = Console.ReadLine();

            bool isSaved = db.SaveChanges() > 0;

            if (isSaved)
            {
                Console.WriteLine("Saved Successful!");
            }

            Console.ReadKey();
        }
    }
}
