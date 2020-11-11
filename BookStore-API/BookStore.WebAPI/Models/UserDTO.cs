using System.ComponentModel.DataAnnotations;

namespace BookStore.WebAPI.Models
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(32, ErrorMessage = "Your Password is invalid. Limited from {2} characters to {1} characters.", MinimumLength = 8)]
        public string Password { get; set; }
    }
}