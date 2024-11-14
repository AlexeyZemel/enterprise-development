using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class AlbumService(IRepository<Album> albumRepository, IMapper mapper) : IService<AlbumDto, Album>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return albumRepository.Delete(id);
    }

    public IEnumerable<Album> GetAll()
    {
        var albums = albumRepository.GetAll();
        return albums;
    }

    public Album? GetById(int id)
    {
        return albumRepository.GetById(id);
    }

    public Album? Post(AlbumDto entity)
    {
        var album = mapper.Map<Album>(entity);
        album.Id = _id++;
        return albumRepository.Post(album);
    }

    public bool Put(int id, AlbumDto entity)
    {
        var album = mapper.Map<Album>(entity);
        return albumRepository.Put(id, album);
    }
}
