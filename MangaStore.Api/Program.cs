using MangaStore.Application;
using MangaStore.Infra;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfra();
    builder.Services.AddControllers();
}

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
