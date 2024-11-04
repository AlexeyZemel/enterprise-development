using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class ActorRepository : IRepository<Actor>
{
    private readonly List<Actor> _actors = [];

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Actor> GetAll() => _actors;

    public Actor? GetById(int id) => _actors.Find(a => a.Id == id);

    public Actor? Post(Actor entity)
    {
        throw new NotImplementedException();
    }

    public bool Put(int id, Actor entity)
    {
        throw new NotImplementedException();
    }
}
