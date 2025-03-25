
namespace MoodTunesApp.App.Models
{
    public class PlaylistMusic : ModelBase
    {
        public Guid PlaylistId {get; set;}
        public Playlist Playlist {get; set;}

        public Guid MusicId {get; set;}
        public Music Music {get; set;}


        public PlaylistMusic() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now){}
        public PlaylistMusic(Guid id, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
        }
    }
}