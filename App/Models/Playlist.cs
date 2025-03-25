
using System.ComponentModel.DataAnnotations;

namespace MoodTunesApp.App.Models
{
    public class Playlist : ModelBase
    {
        [Required]
        public string ImageURL {get; set;}
        [Required]
        public string Name {get; set;}

        public Guid LibraryId {get; set;}

        public ICollection<Music> Musics {get; set;}
        public ICollection<PlaylistMusic> PlaylistMusics {get; set;}
        public Library Library {get; set;}


        public Playlist() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public Playlist(Guid id, string imageURL, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            ImageURL = imageURL;
        }
    }
}