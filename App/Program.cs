using MoodTunesApp.App.Config;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    builder.Services.AddOpenApi();

    AppConfig.StartDependencies(builder);

    builder.Services.AddControllers();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
    }

    app.UseHttpsRedirection();
    // app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    throw new Exception($"Erro ao iniciar a aplicação: {ex.Message}", ex);
}




