using Microsoft.EntityFrameworkCore;
using MoodTunesApp.App.DataBase;
using MoodTunesApp.App.Repositories;
using MoodTunesApp.App.Services;

namespace MoodTunesApp.App.Config
{
    public static class AppConfig
    {
        public static void StartDependencies(WebApplicationBuilder builder)
        {

            string connectionString = "Server=localhost;Database=MoodTunesdb;User Id=root;Password=senharoot;";
            
            try
            {
                builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

                builder.Services.AddScoped<UserRepository, UserRepository>();
                builder.Services.AddScoped<MoodMaterRepository, MoodMaterRepository>();
                builder.Services.AddScoped<LibraryRepository, LibraryRepository>();
                builder.Services.AddScoped<UserService, UserService>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao iniciar as dependencias: {ex.Message}", ex);
            }
        }
    }
}