﻿using MediaLibrary.Domain.Entities;

namespace MediaLibrary.Domain.Repositories;

public class ActorGenreRepository(IRepository<Genre> genreRepository, 
    IRepository<Actor> actorRepository) : IRepository<ActorGenre>
{
    private readonly List<ActorGenre> _actorGenres = [];
    public bool Delete(int id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        _actorGenres.Remove(value);
        return true;
    }

    public IEnumerable<ActorGenre> GetAll() => _actorGenres;

    public ActorGenre? GetById(int id) => _actorGenres.Find(ag => ag.ActorId == id);

    public ActorGenre? Post(ActorGenre entity)
    {
        var genre = genreRepository.GetById(entity.GenreId);
        if (genre == null)
            return null;

        var actor = actorRepository.GetById(entity.ActorId);
        if (actor == null)
            return null;

        _actorGenres.Add(entity);
        return entity;
    }

    public bool Put(int id, ActorGenre entity)
    {
        var oldValue = GetById(id);
        if (oldValue == null)
            return false;

        var actor = actorRepository.GetById(entity.ActorId);
        if (actor == null)
            return false;

        var genre = genreRepository.GetById(entity.GenreId);
        if (genre == null)
            return false;

        oldValue.GenreId = entity.GenreId;
        return true;
    }
}
