using MediaLibrary.API;
using MediaLibrary.API.Services;
using MediaLibrary.Domain.Repositories;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddSingleton<ActorService>();
builder.Services.AddSingleton<AlbumService>();
builder.Services.AddSingleton<GenreService>();
builder.Services.AddSingleton<TrackService>();
builder.Services.AddSingleton<QueryService>();
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
