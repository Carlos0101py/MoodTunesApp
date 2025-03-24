
namespace MoodTunesApp.App.Models
{
    public class Library : ModelBase
    {
        public Library() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public Library(Guid id, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
        }
    }
}