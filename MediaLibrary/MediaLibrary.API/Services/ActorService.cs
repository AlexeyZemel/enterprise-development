using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class ActorService(IRepository<Actor> actorRepository, IMapper mapper) : IService<ActorDto, Actor>
{
    public async Task<bool> Delete(int id)
    {
        return await actorRepository.Delete(id);
    }

    public async Task<IEnumerable<Actor>> GetAll()
    {
        var actors = await actorRepository.GetAll();
        return actors;
    }

    public async Task<Actor?> GetById(int id)
    {
        return await actorRepository.GetById(id);
    }

    public async Task<Actor?> Post(ActorDto entity)
    {
        var actor = mapper.Map<Actor>(entity);       
        return await actorRepository.Post(actor);
    }

    public async Task<bool> Put(int id, ActorDto entity)
    {
        var actor = mapper.Map<Actor>(entity);
        return await actorRepository.Put(id, actor);
    }
}
