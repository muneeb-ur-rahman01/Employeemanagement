using EmployeeManagement.API.Models;
using Empployeemanagement.API.Models;

namespace EmployeeManagement.API.Interfaces
{
    public interface IAuthRepository
    {
        Task Register(User user);

        Task<User> Login(string email, string password);

    }
}
