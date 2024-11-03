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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
