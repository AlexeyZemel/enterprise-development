using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class ActorGenreService(IRepository<ActorGenre> actorGenreRepository, IMapper mapper) : IService<ActorGenreDto, ActorGenre>
{
    private int _id = 1;
    public bool Delete(int id) => actorGenreRepository.Delete(id);

    public IEnumerable<ActorGenre> GetAll() => actorGenreRepository.GetAll();

    public ActorGenre? GetById(int id)
    {
        var value = actorGenreRepository.GetById(id);
        return value == null ? null : value;
    }
 
    public ActorGenre? Post(ActorGenreDto entity)
    {
        var value = mapper.Map<ActorGenre>(entity);
        value.Id = _id++;
        return actorGenreRepository.Post(value);
    }

    public bool Put(int id, ActorGenreDto entity)
    {
        var value = mapper.Map<ActorGenre>(entity);
        return actorGenreRepository.Put(id, value);
    }
}
