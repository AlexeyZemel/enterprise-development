using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;

namespace MediaLibrary.API;

/// <summary>
/// Класс для маппинга
/// </summary>
public class Mapping : Profile 
{
    /// <summary>
    /// Маппинг сущностей
    /// </summary>
    public Mapping()
    {
        CreateMap<Actor, Actor>().ReverseMap();
        CreateMap<Album, AlbumDto>().ReverseMap();
        CreateMap<Track, TrackDto>().ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<ActorGenre, ActorGenreDto>().ReverseMap();
    }
}
