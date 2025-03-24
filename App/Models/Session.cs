using System.ComponentModel.DataAnnotations;

namespace MoodTunesApp.App.Models
{
    public class Session : ModelBase
    {
        [Required]
        public Guid Token {get; set;}
        
        [Required]
        public Guid UserId { get; set; }

        /*Propriedade de navegação, ajuda na hora de recuperar
        os dados sem a necessidade de joins ( Pesquisar depois )
        */
        public User User {get; set;}
        

        public Session() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }
        public Session(Guid id, Guid token, DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            Token = token;
        }
    }
}