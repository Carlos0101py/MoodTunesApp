using System.Text.Json.Serialization;

namespace MoodTunesApp.App.Models
{
    public class MoodMater : ModelBase
    {
        public ICollection<MoodType> MoodTypes {get;}
        
        [JsonIgnore]
        public User User {get; set;}
        
        
        public MoodMater() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public MoodMater(Guid id, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
        }
    }
}