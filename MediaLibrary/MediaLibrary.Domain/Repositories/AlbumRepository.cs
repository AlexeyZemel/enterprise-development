using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class AlbumRepository : IRepository<Album>
{
    private readonly List<Album> _albums = [];
    
    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Album> GetAll() => _albums;

    public Album? GetById(int id) => _albums.Find(a => a.Id == id);

    public void Post(Album entity)
    {
        throw new NotImplementedException();
    }

    public bool Put(int id, Album entity)
    {
        throw new NotImplementedException();
    }
}
