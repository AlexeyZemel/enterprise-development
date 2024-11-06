using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;

namespace MediaLibrary.API;

public class Mapping : Profile 
{
    public Mapping()
    {
        CreateMap<Actor, ActorDto>().ReverseMap();
        CreateMap<Album, AlbumDto>().ReverseMap();
        CreateMap<Track, TrackDto>().ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();
    }
}
