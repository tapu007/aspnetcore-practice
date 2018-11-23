using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models.EntityModels
{
    public class Employee
    {
        public Employee()
        {
                
        }
        public Employee(string name, string regNo, double salary)
        {
            Name = name;
            RegNo = regNo;
            Salary = salary;
        }

        public int Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Display(Name="Reg No")]
        public string RegNo { get; set; }
        [Required]
        [Range(1,20000)]
        public double Salary { get; set; }

        [Display(Name="Mobile Number")]
        public string MobileNumber { get; set; }

        public string Address { get; set; }
        
        [NotMapped]
        public string Info { get; set; }

        public string GetInfo()
        {
            return $"{Name} , {RegNo}, {Salary}";
        }
    }
}
