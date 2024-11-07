using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class ActorService(IRepository<Actor> actorRepository, IMapper mapper) : IService<ActorDto>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return actorRepository.Delete(id);
    }

    public IEnumerable<ActorDto> GetAll()
    {
        var actors = actorRepository.GetAll();
        return mapper.Map<IEnumerable<ActorDto>>(actors);
    }

    public ActorDto? GetById(int id)
    {
        var actor = actorRepository.GetById(id);
        return actor == null ? null : mapper.Map<ActorDto>(actor);
    }

    public ActorDto? Post(ActorDto entity)
    {
        var actor = mapper.Map<Actor>(entity);
        actor.Id = _id++;
        return mapper.Map<ActorDto>(actorRepository.Post(actor));
    }

    public bool Put(int id, ActorDto entity)
    {
        var actor = mapper.Map<Actor>(entity);
        return actorRepository.Put(id, actor);
    }
}
