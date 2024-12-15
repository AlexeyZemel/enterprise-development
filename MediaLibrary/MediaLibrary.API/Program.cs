using MediaLibrary.API;
using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using MediaLibrary.Domain;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddScoped<IService<ActorDto, Actor>,ActorService>();
builder.Services.AddScoped<IService<AlbumDto, Album>, AlbumService>();
builder.Services.AddScoped<IService<GenreDto, Genre>, GenreService>();
builder.Services.AddScoped<IService<TrackDto, Track>, TrackService>();
builder.Services.AddScoped<QueryService>();
builder.Services.AddScoped<IService<ActorGenreDto, ActorGenre>, ActorGenreService>();
builder.Services.AddScoped<IRepository<Actor>, ActorRepository>();
builder.Services.AddScoped<IRepository<Album>, AlbumRepository>();
builder.Services.AddScoped<IRepository<Track>, TrackRepository>();
builder.Services.AddScoped<IRepository<Genre>, GenreRepository>();
builder.Services.AddScoped<IRepository<ActorGenre>, ActorGenreRepository>();

builder.Services.AddCors(options => 
                options.AddDefaultPolicy(policy => 
                { 
                    policy.AllowAnyOrigin(); 
                    policy.AllowAnyMethod();
                    policy.AllowAnyHeader(); 
                }));

builder.Services.AddControllers();

builder.Services.AddDbContext<MediaLibraryContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgre")));

builder.Services.AddAutoMapper(typeof(Mapping));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.MapControllers();

app.Run();
