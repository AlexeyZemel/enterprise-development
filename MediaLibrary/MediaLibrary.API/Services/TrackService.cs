using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class TrackService(IRepository<Track> trackRepository, IMapper mapper) : IService<TrackDto, Track>
{
    public async Task<bool> Delete(int id)
    {
        return await trackRepository.Delete(id);
    }

    public async Task<IEnumerable<Track>> GetAll()
    {
        var tracks = await trackRepository.GetAll();
        return tracks;
    }

    public async Task<Track?> GetById(int id)
    {
        return await trackRepository.GetById(id);
    }

    public async Task<Track?> Post(TrackDto entity)
    {
        var track = mapper.Map<Track>(entity);
        return await trackRepository.Post(track);
    }

    public async Task<bool> Put(int id, TrackDto entity)
    {
        var track = mapper.Map<Track>(entity);
        return await trackRepository.Put(id, track);
    }
}
