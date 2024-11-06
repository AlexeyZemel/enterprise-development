using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class AlbumService(AlbumRepository albumRepository, IMapper mapper) : IService<AlbumDto>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return albumRepository.Delete(id);
    }

    public IEnumerable<AlbumDto> GetAll()
    {
        var albums = albumRepository.GetAll();
        return mapper.Map<IEnumerable<AlbumDto>>(albums);
    }

    public AlbumDto? GetById(int id)
    {
        var album = albumRepository.GetById(id);
        return album == null ? null : mapper.Map<AlbumDto>(album);
    }

    public AlbumDto? Post(AlbumDto entity)
    {
        var album = mapper.Map<Album>(entity);
        album.Id = _id++;
        return mapper.Map<AlbumDto>(albumRepository.Post(album));
    }

    public bool Put(int id, AlbumDto entity)
    {
        var album = mapper.Map<Album>(entity);
        return albumRepository.Put(id, album);
    }
}
