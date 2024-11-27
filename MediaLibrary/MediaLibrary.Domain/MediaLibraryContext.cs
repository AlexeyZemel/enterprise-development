using MediaLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaLibrary.Domain;

public class MediaLibraryContext(DbContextOptions<MediaLibraryContext> options) : DbContext(options)
{
    public DbSet<Actor> Actors { get; set; }
    public DbSet<ActorGenre> ActorGenres { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Track> Tracks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActorGenre>()
            .HasOne<Actor>()
            .WithMany()
            .HasForeignKey(ag => ag.ActorId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ActorGenre>()
            .HasOne<Genre>()
            .WithMany()
            .HasForeignKey(g => g.GenreId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Album>()
            .HasOne<Actor>()
            .WithMany()
            .HasForeignKey(a => a.ActorId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Track>()
            .HasOne<Album>()
            .WithMany()
            .HasForeignKey(a => a.AlbumId)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}
