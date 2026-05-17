using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.API.DTOs

{

    public class RegisterDto
    {
        public string Fullname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string password { get; set; }

    }
}