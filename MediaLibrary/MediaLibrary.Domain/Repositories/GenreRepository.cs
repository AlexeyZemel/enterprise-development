using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class GenreRepository : IRepository<Genre>
{
    private readonly List<Genre> _genres = [];

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Genre> GetAll() => _genres;

    public Genre? GetById(int id) => _genres.Find(g => g.Id == id);

    public Genre? Post(Genre entity)
    {
        throw new NotImplementedException();
    }

    public bool Put(int id, Genre entity)
    {
        throw new NotImplementedException();
    }
}
