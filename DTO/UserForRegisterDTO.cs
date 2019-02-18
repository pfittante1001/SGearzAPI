
using System.ComponentModel.DataAnnotations;

namespace SGearzAPI.API.DTO
{
    public class UserForRegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "You must specify a password between 6 - 8 characters in length")]
        public string Password { get; set; }
    }
}