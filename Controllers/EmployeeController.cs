using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Interfaces;
using EmployeeManagement.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagement.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository )
        {
            _repository = repository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var employees= await _repository.GetAllAsync();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeDto dto)
        {
            var employee = new Employee
            {
               Name = dto.name,
               Email = dto.Email,
               Salary = dto.Salary,
               Department = dto.Department
            };

            return Ok(employee);
        }
        
    }
}