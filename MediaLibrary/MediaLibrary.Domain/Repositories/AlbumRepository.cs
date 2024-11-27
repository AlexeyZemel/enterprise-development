using MediaLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaLibrary.Domain.Repositories;

public class AlbumRepository(MediaLibraryContext context, IRepository<Actor> actorRepository) : IRepository<Album>
{
    public async Task<bool> Delete(int id)
    {
        var value = await GetById(id);

        if (value == null)
            return false;

        context.Albums.Remove(value);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Album>> GetAll() => await context.Albums.ToListAsync();

    public async Task<Album?> GetById(int id) => await context.Albums.FirstOrDefaultAsync(a => a.Id == id);

    public async Task<Album?> Post(Album entity)
    {
        var actor = await actorRepository.GetById(entity.ActorId);
        if (actor == null)
            return null;

        context.Albums.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Put(int id, Album entity)
    {
        var oldValue = await GetById(id);
        if (oldValue == null)
            return false;

        var actor = await actorRepository.GetById(entity.ActorId);
        if (actor == null)
            return false;

        oldValue.ActorId = entity.ActorId;
        oldValue.Name = entity.Name;
        oldValue.Date = entity.Date;

        await context.SaveChangesAsync();
        return true;
    }
}
