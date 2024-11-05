using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class ActorRepository : IRepository<Actor>
{
    private readonly List<Actor> _actors = [];
    
    public bool Delete(int id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        _actors.Remove(value);
        return true;
    }

    public IEnumerable<Actor> GetAll() => _actors;

    public Actor? GetById(int id) => _actors.Find(a => a.Id == id);

    public Actor? Post(Actor entity)
    {
        _actors.Add(entity);
        return entity;
    }

    public bool Put(int id, Actor entity)
    {
        var oldValue = GetById(id);
        if (oldValue == null)
            return false;

        oldValue.Name = entity.Name;
        oldValue.Description = entity.Description;
        return true;
    }
}
