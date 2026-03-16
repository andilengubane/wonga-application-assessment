using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WongaApplication.Domain.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }

        [Required]
        [EmailAddress]
        public string Username { get; set; } = string.Empty;
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; } = string.Empty;
        public DateTime DateLogged { get; set; } = DateTime.Now;
    }
}
