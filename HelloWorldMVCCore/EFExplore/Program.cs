using System;
using HelloWorldMVCCore.Models;
using HelloWorldMVCCore.ProjectDatabaseContext;

namespace EFExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectDbContext context = new ProjectDbContext();
            Employee employee = new Employee()
            {
                Name = "New",
                RegNo = "001",
                Address = "Dhaka",
                MobileNumber = "9383",
                Salary = 8832

            };

            context.Employees.Add(employee);
            bool isSaved = context.SaveChanges() > 0;
            if (isSaved)
            {
                Console.WriteLine("Saved Successful!");
            }

            Console.ReadKey();
        }
    }
}
