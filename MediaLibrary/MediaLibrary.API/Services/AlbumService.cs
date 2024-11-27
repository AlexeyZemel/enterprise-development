using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class AlbumService(IRepository<Album> albumRepository, IMapper mapper) : IService<AlbumDto, Album>
{
    public async Task<bool> Delete(int id)
    {
        return await albumRepository.Delete(id);
    }

    public async Task<IEnumerable<Album>> GetAll()
    {
        var albums = await albumRepository.GetAll();
        return albums;
    }

    public async Task<Album?> GetById(int id)
    {
        return await albumRepository.GetById(id);
    }

    public async Task<Album?> Post(AlbumDto entity)
    {
        var album = mapper.Map<Album>(entity);       
        return await albumRepository.Post(album);
    }

    public async Task<bool> Put(int id, AlbumDto entity)
    {
        var album = mapper.Map<Album>(entity);
        return await albumRepository.Put(id, album);
    }
}
