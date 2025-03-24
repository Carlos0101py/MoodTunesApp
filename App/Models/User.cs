using System.ComponentModel.DataAnnotations;
using BCrypt.Net;

namespace MoodTunesApp.App.Models
{
    public class User : ModelBase
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ImageProfileURL { get; set; }

        private string _Password;

        [Required]
        public string Password
        {
            get => _Password;
            set
            {
                _Password = HashPassword(value);
            }
        }

        public Guid MoodMaterId {get; set;}

        /*Propriedade de navegação, ajuda na hora de recuperar
        os dados sem a necessidade de joins ( Pesquisar depois )
        */
        public Session Session {get; set;}
        public MoodMater MoodMater {get; set;}


        public User() : base(Guid.NewGuid(), DateTime.Now, DateTime.Now)
        {
        }

        public User(Guid id, string userName, string email, string imagemProfileURL, string password,
        DateTime createdAt, DateTime updatedAt) : base(id, createdAt, updatedAt)
        {
            UserName = userName;
            Email = email;
            ImageProfileURL = imagemProfileURL;
            Password = password;
        }


        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}