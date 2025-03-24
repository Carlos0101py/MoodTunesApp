using System.ComponentModel.DataAnnotations;

namespace MoodTunesApp.App.DTOs
{
    public class UserDTO
    {
        [Required]
        [MaxLength(20)]
        public string UserName;
        [Required]
        [EmailAddress]
        public string Email;
        [Required]
        [MinLength(8)]
        public string Password;
        [Required]
        [MinLength(8)]
        public string _RePassword;
    }
}