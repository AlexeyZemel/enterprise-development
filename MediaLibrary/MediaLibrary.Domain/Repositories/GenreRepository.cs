using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class GenreRepository : IRepository<Genre>
{
    private readonly List<Genre> _genres = [];

    public bool Delete(int id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        _genres.Remove(value);
        return true;
    }

    public IEnumerable<Genre> GetAll() => _genres;

    public Genre? GetById(int id) => _genres.Find(g => g.Id == id);

    public Genre? Post(Genre entity)
    {
        _genres.Add(entity);
        return entity;
    }

    public bool Put(int id, Genre entity)
    {
        var oldValue = GetById(id);
        if (oldValue == null) 
            return false;

        oldValue.Name = entity.Name;
        return true;
    }
}
