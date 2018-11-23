using EmployeeManagement.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models.DatabaseContext
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {
           
        }

        public EmployeeDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=EmployeeDB;Trusted_Connection=true");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
