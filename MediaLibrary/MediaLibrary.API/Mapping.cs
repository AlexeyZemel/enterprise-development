using AutoMapper;
using MediaLibrary.API.Dto;
using MediaLibrary.Domain.Entities;

namespace MediaLibrary.API;

public class Mapping : Profile 
{
    public Mapping()
    {
        CreateMap<Actor, ActorDto>().ReverseMap();
        // more
    }
}
