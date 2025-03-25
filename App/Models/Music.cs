
using System.ComponentModel.DataAnnotations;

namespace MoodTunesApp.App.Models
{
    public class Music : ModelBase
    {
        [Required]
        public string Name {get; set;}
        [Required]
        public string MusicURL {get; set;}
        [Required]
        public string BannerURL {get; set;}
        [Required]
        public string Genre {get; set;}

        public ICollection<MoodType> MoodType {get; set;}
        public ICollection<Playlist> Playlists {get; set;}
        public ICollection<PlaylistMusic> PlaylistMusics {get; set;}


        public Music() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public Music(Guid id, string name, string musicURL, string bannerURL, string genre, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            Name = name;
            MusicURL = musicURL;
            BannerURL = bannerURL;
            Genre = genre;
        }
    }
}