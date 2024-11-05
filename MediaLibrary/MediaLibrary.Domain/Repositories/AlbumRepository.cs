using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class AlbumRepository(ActorRepository actorRepository) : IRepository<Album>
{
    private readonly List<Album> _albums = [];
    
    public bool Delete(int id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        _albums.Remove(value);
        return true;
    }

    public IEnumerable<Album> GetAll() => _albums;

    public Album? GetById(int id) => _albums.Find(a => a.Id == id);

    public Album? Post(Album entity)
    {
        _albums.Add(entity);
        return entity;
    }

    public bool Put(int id, Album entity)
    {
        var oldValue = GetById(id);
        if (oldValue == null)
            return false;

        var actor = actorRepository.GetById(entity.ActorId);
        if (actor == null)
            return false;

        oldValue.ActorId = entity.ActorId;
        oldValue.Name = entity.Name;
        oldValue.Date = entity.Date;
        return true;
    }
}
