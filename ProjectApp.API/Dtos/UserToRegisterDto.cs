using System.ComponentModel.DataAnnotations;

namespace ProjectApp.API.Dtos
{
    public class UserToRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength=4, ErrorMessage="You must specify password between 4 and 8 characters.")]
        public string Password { get; set; }
    }
}