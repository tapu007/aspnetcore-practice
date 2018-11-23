using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagemetApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagemetApp.DatabaseContext
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
            optionsBuilder.UseSqlServer("Server=(localdsd);Database=EmployeeDB;Trusted_Connection=true");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
