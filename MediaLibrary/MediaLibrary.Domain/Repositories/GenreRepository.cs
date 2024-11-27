using MediaLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaLibrary.Domain.Repositories;

public class GenreRepository(MediaLibraryContext context) : IRepository<Genre>
{
    public async Task<bool> Delete(int id)
    {
        var value = await GetById(id);

        if (value == null)
            return false;

        context.Genres.Remove(value);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Genre>> GetAll() => await context.Genres.ToListAsync();

    public async Task<Genre?> GetById(int id) => await context.Genres.FirstOrDefaultAsync(g => g.Id == id);

    public async Task<Genre?> Post(Genre entity)
    {
        context.Genres.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Put(int id, Genre entity)
    {
        var oldValue = await GetById(id);
        if (oldValue == null) 
            return false;

        oldValue.Name = entity.Name;

        await context.SaveChangesAsync();
        return true;
    }
}
