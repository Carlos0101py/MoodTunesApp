using System.ComponentModel.DataAnnotations;

namespace MoodTunesApp
{
    public class SessionDTO
    {
        [Required]
        public Guid Token {get; set;}
        [Required]
        public Guid UserId {get; set;}
    }
}