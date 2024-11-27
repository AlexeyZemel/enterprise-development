using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class ActorGenreService(IRepository<ActorGenre> actorGenreRepository, IMapper mapper) : IService<ActorGenreDto, ActorGenre>
{
    public async Task<bool> Delete(int id) => await actorGenreRepository.Delete(id);

    public async Task<IEnumerable<ActorGenre>> GetAll() => await actorGenreRepository.GetAll();

    public async Task<ActorGenre?> GetById(int id)
    {
        return await actorGenreRepository.GetById(id);
    }
 
    public async Task<ActorGenre?> Post(ActorGenreDto entity)
    {
        var value = mapper.Map<ActorGenre>(entity);
        return await actorGenreRepository.Post(value);
    }

    public async Task<bool> Put(int id, ActorGenreDto entity)
    {
        var value = mapper.Map<ActorGenre>(entity);
        return await actorGenreRepository.Put(id, value);
    }
}
