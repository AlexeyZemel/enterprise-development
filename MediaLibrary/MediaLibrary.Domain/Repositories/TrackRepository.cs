using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class TrackRepository : IRepository<Track>
{
    private readonly List<Track> _tracks = [];

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Track> GetAll() => _tracks;

    public Track? GetById(int id) => _tracks.Find(t => t.Id == id);

    public Track? Post(Track entity)
    {
        throw new NotImplementedException();
    }

    public bool Put(int id, Track entity)
    {
        throw new NotImplementedException();
    }
}
