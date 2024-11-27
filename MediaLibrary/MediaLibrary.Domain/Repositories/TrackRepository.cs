using MediaLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaLibrary.Domain.Repositories;

public class TrackRepository(MediaLibraryContext context, IRepository<Album> albumRepository) : IRepository<Track>
{
    public async Task<bool> Delete(int id)
    {
        var value = await GetById(id);

        if (value == null)
            return false;

        context.Tracks.Remove(value);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Track>> GetAll() => await context.Tracks.ToListAsync();

    public async Task<Track?> GetById(int id) => await context.Tracks.FirstOrDefaultAsync(t => t.Id == id);

    public async Task<Track?> Post(Track entity)
    {
        var album = await albumRepository.GetById(entity.AlbumId);
        if (album == null)
            return null;

        context.Tracks.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Put(int id, Track entity)
    {
        var oldValue = await GetById(id);
        if (oldValue == null)
            return false;

        var album = await albumRepository.GetById(entity.AlbumId);
        if (album == null)
            return false;

        oldValue.Name = entity.Name;
        oldValue.Number = entity.Number;
        oldValue.AlbumId = entity.AlbumId;
        oldValue.Time = entity.Time;

        await context.SaveChangesAsync();
        return true;
    }
}
