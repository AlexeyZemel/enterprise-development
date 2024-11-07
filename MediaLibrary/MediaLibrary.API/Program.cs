using MediaLibrary.API;
using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddSingleton<IService<ActorDto>,ActorService>();
builder.Services.AddSingleton<IService<AlbumDto>, AlbumService>();
builder.Services.AddSingleton<IService<GenreDto>, GenreService>();
builder.Services.AddSingleton<IService<TrackDto>, TrackService>();
builder.Services.AddSingleton<QueryService>();
builder.Services.AddSingleton<IService<ActorGenre>, ActorGenreService>();
builder.Services.AddSingleton<IRepository<Actor>, ActorRepository>();
builder.Services.AddSingleton<IRepository<Album>, AlbumRepository>();
builder.Services.AddSingleton<IRepository<Track>, TrackRepository>();
builder.Services.AddSingleton<IRepository<Genre>, GenreRepository>();
builder.Services.AddSingleton<IRepository<ActorGenre>, ActorGenreRepository>();

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
