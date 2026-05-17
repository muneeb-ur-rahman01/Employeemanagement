using System.ComponentModel.DataAnnotations;

namespace Empployeemanagement.API.Models
{
    public class User
    {
        public int id { get; set; }

        public string Fullname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string passwordhash { get; set; }

        [Required]
        public string Role { get; set; }
    }
}