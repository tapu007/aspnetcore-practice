using HelloWorldMVCCore.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldMVCCore.ProjectDatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            
        }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EmployeeDB;MultipleActiveResultSets=True;Trusted_Connection=yes;Integrated Security=SSPI");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
