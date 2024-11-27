using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class GenreService(IRepository<Genre> genreRepository, IMapper mapper) : IService<GenreDto, Genre>
{
    public async Task<bool> Delete(int id)
    {
        return await genreRepository.Delete(id);
    }

    public async Task<IEnumerable<Genre>> GetAll()
    {
        var genres = await genreRepository.GetAll();
        return genres;
    }

    public async Task<Genre?> GetById(int id)
    {
        return await genreRepository.GetById(id);
    }

    public async Task<Genre?> Post(GenreDto entity)
    {
        var genre = mapper.Map<Genre>(entity);
        return await genreRepository.Post(genre);
    }

    public async Task<bool> Put(int id, GenreDto entity)
    {
        var genre = mapper.Map<Genre>(entity);
        return await genreRepository.Put(id, genre);
    }
}
