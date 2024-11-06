using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.OpenApi.Validations;

namespace MediaLibrary.API.Services;

public class TrackService(TrackRepository trackRepository, IMapper mapper) : IService<TrackDto>
{
    private int _id = 1;
    public bool Delete(int id)
    {
        return trackRepository.Delete(id);
    }

    public IEnumerable<TrackDto> GetAll()
    {
        var tracks = trackRepository.GetAll();
        return mapper.Map<IEnumerable<TrackDto>>(tracks);
    }

    public TrackDto? GetById(int id)
    {
        var track = trackRepository.GetById(id);
        return track == null ? null : mapper.Map<TrackDto>(track);
    }

    public TrackDto? Post(TrackDto entity)
    {
        var track = mapper.Map<Track>(entity);
        track.Id = _id++;
        return mapper.Map<TrackDto>(trackRepository.Post(track));
    }

    public bool Put(int id, TrackDto entity)
    {
        var track = mapper.Map<Track>(entity);
        return trackRepository.Put(id, track);
    }
}
