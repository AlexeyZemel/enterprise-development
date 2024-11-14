using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class GenreService(IRepository<Genre> genreRepository, IMapper mapper) : IService<GenreDto, Genre>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return genreRepository.Delete(id);
    }

    public IEnumerable<Genre> GetAll()
    {
        var genres = genreRepository.GetAll();
        return genres;
    }

    public Genre? GetById(int id)
    {
        return genreRepository.GetById(id);
    }

    public Genre? Post(GenreDto entity)
    {
        var genre = mapper.Map<Genre>(entity);
        genre.Id = _id++;
        return genreRepository.Post(genre);
    }

    public bool Put(int id, GenreDto entity)
    {
        var genre = mapper.Map<Genre>(entity);
        return genreRepository.Put(id, genre);
    }
}
