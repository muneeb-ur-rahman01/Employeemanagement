using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.Interfaces;
using Microsoft.EntityFrameworkCore;
using Empployeemanagement.API.Models;

namespace EmployeeManagement.API.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        public readonly ApplicationContext _context;
        public AuthRepository(ApplicationContext context )
        {
            _context = context;
        }

        public async Task Register (User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Login(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.passwordhash == password);

        }
    }
}
