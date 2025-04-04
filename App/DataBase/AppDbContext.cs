using Microsoft.EntityFrameworkCore;
using MoodTunesApp.App.Models;

namespace MoodTunesApp.App.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Library> Library {get; set;}
        public DbSet<MoodMater> MoodMater {get; set;}
        public DbSet<MoodType> MoodType {get; set;}
        public DbSet<Music> Music {get; set;}
        public DbSet<Playlist> Playlist {get; set;}
        public DbSet<PlaylistMusic> PlaylistMusic {get; set;}
        public DbSet<Session> Session {get; set;}
        public DbSet<User> User {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Library>()
            .HasKey(s => s.Id);
            modelBuilder.Entity<MoodMater>()
            .HasKey(s => s.Id);
            modelBuilder.Entity<MoodType>()
            .HasKey(s => s.Id);
            modelBuilder.Entity<Music>()
            .HasKey(s => s.Id);
            modelBuilder.Entity<Playlist>()
            .HasKey(s => s.Id);
            modelBuilder.Entity<PlaylistMusic>()
            .HasKey(pm => new { pm.MusicId, pm.PlaylistId });
            modelBuilder.Entity<Session>()
            .HasKey(s => s.Id);
            modelBuilder.Entity<User>()
            .HasKey(s => s.Id);


            //table user configuração de index
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.ImageProfileURL).IsRequired(false);

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
            .WithOne(mm => mm.User)
            .HasForeignKey<User>(u => u.MoodMaterId);

            modelBuilder.Entity<User>()
            .HasOne(u => u.Library)
            .WithOne(l => l.User)
            .HasForeignKey<User>(u => u.LibraryId);


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

            modelBuilder.Entity<Library>()
            .HasMany(l => l.Playlists)
            .WithOne(p => p.Library)
            .HasForeignKey(p => p.LibraryId);

            modelBuilder.Entity<Music>()
            .HasMany(m => m.MoodType)
            .WithOne(mt => mt.Music)
            .HasForeignKey(mt => mt.MusicId);


            /*
                Relacionamento muitos para muitos

                - Uma Playlist pode conter várias Músicas, e uma Música pode estar presente em várias Playlists.
                - Para representar essa relação, criamos uma tabela intermediária chamada PlaylistMusic.
                - A tabela PlaylistMusic terá duas chaves estrangeiras:
                - PlaylistId (referenciando Playlist)
                - MusicId (referenciando Music)
                - A definição da tabela intermediária será feita com .UsingEntity<PlaylistMusic>()
            */

            modelBuilder.Entity<PlaylistMusic>()
                .HasOne(pm => pm.Music)
                .WithMany(m => m.PlaylistMusics)
                .HasForeignKey(pm => pm.MusicId); // Define a chave estrangeira para Music

            modelBuilder.Entity<PlaylistMusic>()
                .HasOne(pm => pm.Playlist)
                .WithMany(p => p.PlaylistMusics)
                .HasForeignKey(pm => pm.PlaylistId);
        }
    }
}