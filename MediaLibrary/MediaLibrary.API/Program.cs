using MediaLibrary.API;
using MediaLibrary.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ActorGenreRepository>();
builder.Services.AddSingleton<GenreRepository>();
builder.Services.AddSingleton<ActorRepository>();
builder.Services.AddSingleton<AlbumRepository>();
builder.Services.AddSingleton<TrackRepository>();

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
