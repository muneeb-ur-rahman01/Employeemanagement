using EmployeeManagement.API.Models;
using Empployeemanagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.DTOs
{

    public class ApplicationContext : DbContext
    { 
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Department>()
                .Property(d => d.EmployeeSalary)
                .HasPrecision(18, 2);
        }

    }

}