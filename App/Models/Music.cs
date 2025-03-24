
namespace MoodTunesApp.App.Models
{
    public class Music : ModelBase
    {
        public string MusicURL {get; set;}
        public string BannerURL {get; set;}
        public string Genre {get; set;} 


        public Music() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public Music(Guid id, string musicURL, string bannerURL, string genre, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            MusicURL = musicURL;
            BannerURL = bannerURL;
            Genre = genre;
        }
    }
}