using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class ActorService(IRepository<Actor> actorRepository, IMapper mapper) : IService<ActorDto, Actor>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return actorRepository.Delete(id);
    }

    public IEnumerable<Actor> GetAll()
    {
        var actors = actorRepository.GetAll();
        return actors;
    }

    public Actor? GetById(int id)
    {
        var actor = actorRepository.GetById(id);
        return actor == null ? null : actor;
    }

    public Actor? Post(ActorDto entity)
    {
        var actor = mapper.Map<Actor>(entity);
        actor.Id = _id++;
        return actorRepository.Post(actor);
    }

    public bool Put(int id, ActorDto entity)
    {
        var actor = mapper.Map<Actor>(entity);
        return actorRepository.Put(id, actor);
    }
}
