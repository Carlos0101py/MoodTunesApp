
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoodTunesApp.App.Models
{
    public class Library : ModelBase
    {   
        [Required]
        public string Name {get; set;}

        public ICollection<Playlist> Playlists {get; set;}

        [JsonIgnore]
        public User User {get; set;}


        public Library() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public Library(Guid id, string name,DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            Name = name;
        }
    }
}