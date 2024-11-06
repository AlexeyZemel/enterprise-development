using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class GenreService(GenreRepository genreRepository, IMapper mapper) : IService<GenreDto>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return genreRepository.Delete(id);
    }

    public IEnumerable<GenreDto> GetAll()
    {
        var genres = genreRepository.GetAll();
        return mapper.Map<IEnumerable<GenreDto>>(genres);
    }

    public GenreDto? GetById(int id)
    {
        var genre = genreRepository.GetById(id);
        return genre == null ? null : mapper.Map<GenreDto>(genre);
    }

    public GenreDto? Post(GenreDto entity)
    {
        var genre = mapper.Map<Genre>(entity);
        genre.Id = _id++;
        return mapper.Map<GenreDto>(genreRepository.Post(genre));
    }

    public bool Put(int id, GenreDto entity)
    {
        var genre = mapper.Map<Genre>(entity);
        return genreRepository.Put(id, genre);
    }
}
