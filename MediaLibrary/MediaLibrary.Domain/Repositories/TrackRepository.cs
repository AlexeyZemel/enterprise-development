using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class TrackRepository(IRepository<Album> albumRepository) : IRepository<Track>
{
    private readonly List<Track> _tracks = [];

    public bool Delete(int id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        _tracks.Remove(value);
        return true;
    }

    public IEnumerable<Track> GetAll() => _tracks;

    public Track? GetById(int id) => _tracks.Find(t => t.Id == id);

    public Track? Post(Track entity)
    {
        var album = albumRepository.GetById(entity.AlbumId);
        if (album == null)
            return null;

        _tracks.Add(entity);
        return entity;
    }

    public bool Put(int id, Track entity)
    {
        var oldValue = GetById(id);
        if (oldValue == null)
            return false;

        var album = albumRepository.GetById(entity.AlbumId);
        if (album == null)
            return false;

        oldValue.Name = entity.Name;
        oldValue.Number = entity.Number;
        oldValue.AlbumId = entity.AlbumId;
        oldValue.Time = entity.Time;
        return true;
    }
}
