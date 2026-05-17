using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.API.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public String Department { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public DateOnly HiringDate { get; set; }

        public string Email { get; set; }
    }
}