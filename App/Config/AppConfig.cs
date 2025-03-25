using Microsoft.EntityFrameworkCore;
using MoodTunesApp.App.DataBase;

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
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao iniciar as dependencias: {ex.Message}", ex);
            }
        }
    }
}