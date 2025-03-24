using Microsoft.EntityFrameworkCore;
using MoodTunesApp.App.Models;

namespace MoodTunesApp.App.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*
                Relacionamento um pra um

                A tabela que receberá a FK deverar ser o tipo
                de ( modelBuilder.Entity<Session> )

                a Definição da FK será feita na
                tabela indicada no:
                ( .HasForeignKey<Session>(s => s.UserId); )
            */

            modelBuilder.Entity<Session>()
            .HasOne(s => s.User)
            .WithOne(u => u.Session)
            .HasForeignKey<Session>(s => s.UserId);

            modelBuilder.Entity<User>()
            .HasOne(u => u.MoodMater)
            .WithOne(m => m.User)
            .HasForeignKey<User>(u => u.MoodMaterId);

            modelBuilder.Entity<User>()
            .HasOne(u => u.MoodMater)
            .WithOne(mm => mm.User)
            .HasForeignKey<User>(u => u.MoodMaterId);


            /*
                Relacionamento um para muitos

                - Um MoodMater pode ter vários MoodTypes, mas cada MoodType pertence a apenas um MoodMater.
                - A tabela que receberá a FK será a tabela MoodType, pois cada MoodType precisa saber a qual MoodMater pertence.
                - A definição da FK será feita na tabela MoodType usando:
                ( .HasForeignKey<MoodType>(mt => mt.MoodMaterId); )
                - Isso significa que a chave estrangeira MoodMaterId será armazenada na tabela MoodType,
                criando um relacionamento onde um MoodMater pode estar associado a vários MoodTypes.
            */

            modelBuilder.Entity<MoodMater>()
            .HasMany(mm => mm.MoodTypes)
            .WithOne(mt => mt.MoodMater)
            .HasForeignKey(mt => mt.MoodMaterId);
        }
    }
}