
using System.ComponentModel.DataAnnotations;

namespace MoodTunesApp.App.Models
{
    public class MoodType : ModelBase
    {
        [Required]
        public string Name {get; set;}

        public Guid MoodMaterId { get; set; }
        public MoodMater MoodMater {get; set;}

        
        public MoodType() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public MoodType(Guid id, string name, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            Name = name;
        }
    }
}