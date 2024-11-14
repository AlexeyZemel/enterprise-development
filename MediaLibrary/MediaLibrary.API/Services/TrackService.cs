using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;

namespace MediaLibrary.API.Services;

public class TrackService(IRepository<Track> trackRepository, IMapper mapper) : IService<TrackDto, Track>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return trackRepository.Delete(id);
    }

    public IEnumerable<Track> GetAll()
    {
        var tracks = trackRepository.GetAll();
        return tracks;
    }

    public Track? GetById(int id)
    {
        return trackRepository.GetById(id);
    }

    public Track? Post(TrackDto entity)
    {
        var track = mapper.Map<Track>(entity);
        track.Id = _id++;
        return trackRepository.Post(track);
    }

    public bool Put(int id, TrackDto entity)
    {
        var track = mapper.Map<Track>(entity);
        return trackRepository.Put(id, track);
    }
}
