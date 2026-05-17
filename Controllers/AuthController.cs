using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Interfaces;
//using EmployeeManagement.API.Models;
using EmployeeManagement.API.Services;
using Empployeemanagement.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        private readonly JwtServices _jwtService;

        public AuthController(
            IAuthRepository authRepository,
            JwtServices jwtService)
        {
            _authRepository = authRepository;
            _jwtService = jwtService;
        }

        [HttpPost("/register")]
        
        public async Task<IActionResult> Register(RegisterDto dto)
        {

            var user = new User
            {
                Fullname = dto.Fullname,
                Email = dto.Email,
                passwordhash = dto.password,
                Role = "Admin"
                
            };
            await _authRepository.Register(user);
            return Ok("User Registerd SuccessfullY");
        }

        [HttpPost("/Login")]

        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _authRepository.Login(dto.Email, dto.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            var token = _jwtService.GenerateToken(user);
            return Ok(token);
        }

    }
}