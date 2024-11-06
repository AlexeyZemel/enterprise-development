using MediaLibrary.API;
using MediaLibrary.API.Services;
using MediaLibrary.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ActorService>();
builder.Services.AddSingleton<AlbumService>();
builder.Services.AddSingleton<GenreService>();
builder.Services.AddSingleton<TrackService>();
builder.Services.AddSingleton<ActorGenreService>();
builder.Services.AddSingleton<ActorRepository>();
builder.Services.AddSingleton<AlbumRepository>();
builder.Services.AddSingleton<TrackRepository>();
builder.Services.AddSingleton<GenreRepository>();
builder.Services.AddSingleton<ActorGenreRepository>();

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(Mapping));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
