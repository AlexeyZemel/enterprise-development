using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class ActorGenreService(ActorGenreRepository actorGenreRepository) : IService<ActorGenre>
{
    public bool Delete(int id) => actorGenreRepository.Delete(id);

    public IEnumerable<ActorGenre> GetAll() => actorGenreRepository.GetAll();

    public ActorGenre? GetById(int id) => actorGenreRepository.GetById(id);
 
    public ActorGenre? Post(ActorGenre entity) => actorGenreRepository.Post(entity);

    public bool Put(int id, ActorGenre entity) => actorGenreRepository.Put(id, entity);
}
