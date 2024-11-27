using MediaLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaLibrary.Domain.Repositories;

public class ActorRepository(MediaLibraryContext context) : IRepository<Actor>
{   
    public async Task<bool> Delete(int id)
    {
        var value = await GetById(id);

        if (value == null)
            return false;

        context.Actors.Remove(value);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Actor>> GetAll() => await context.Actors.ToListAsync();

    public async Task<Actor?> GetById(int id) => await context.Actors.FirstOrDefaultAsync(a => a.Id == id);

    public async Task<Actor?> Post(Actor entity)
    {
        context.Actors.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Put(int id, Actor entity)
    {
        var oldValue = await GetById(id);
        if (oldValue == null)
            return false;

        oldValue.Name = entity.Name;
        oldValue.Description = entity.Description;

        await context.SaveChangesAsync();
        return true;
    }
}
