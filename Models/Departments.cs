namespace EmployeeManagement.API.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeEmail { get; set; }

        public string EmployeePosition { get; set; }

        public decimal EmployeeSalary { get; set; }

        public DateTime JoiningDate { get; set; }

        public string EmployeeAddress { get; set; }

        public string EmployeePhone { get; set; }
    }
}
