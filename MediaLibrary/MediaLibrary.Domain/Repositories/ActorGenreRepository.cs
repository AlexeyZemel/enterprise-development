using MediaLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaLibrary.Domain.Repositories;

public class ActorGenreRepository(MediaLibraryContext context, IRepository<Genre> genreRepository, 
    IRepository<Actor> actorRepository) : IRepository<ActorGenre>
{
    public async Task<bool> Delete(int id)
    {
        var value = await GetById(id);

        if (value == null)
            return false;

        context.ActorGenres.Remove(value);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<ActorGenre>> GetAll() => await context.ActorGenres.ToListAsync();

    public async Task<ActorGenre?> GetById(int id) => await context.ActorGenres.FirstOrDefaultAsync(ag => ag.ActorId == id);

    public async Task<ActorGenre?> Post(ActorGenre entity)
    {
        var genre = await genreRepository.GetById(entity.GenreId);
        if (genre == null)
            return null;

        var actor = await actorRepository.GetById(entity.ActorId);
        if (actor == null)
            return null;

        context.ActorGenres.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Put(int id, ActorGenre entity)
    {
        var oldValue = await GetById(id);
        if (oldValue == null)
            return false;

        var actor = await actorRepository.GetById(entity.ActorId);
        if (actor == null)
            return false;

        var genre = await genreRepository.GetById(entity.GenreId);
        if (genre == null)
            return false;

        oldValue.GenreId = entity.GenreId;

        await context.SaveChangesAsync();
        return true;
    }
}
