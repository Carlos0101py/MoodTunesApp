
using System.ComponentModel.DataAnnotations;

namespace MoodTunesApp.App.Models
{
    public class Playlist : ModelBase
    {
        [Required]
        public string ImageURL {get; set;}
        

        public Playlist() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public Playlist(Guid id, string imageURL, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            ImageURL = imageURL;
        }
    }
}