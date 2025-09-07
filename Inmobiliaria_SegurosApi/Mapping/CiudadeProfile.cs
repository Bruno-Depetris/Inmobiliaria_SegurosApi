using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class CiudadeProfile : Profile
    {
        public CiudadeProfile()
        {
            CreateMap<Ciudade, CiudadeDto>().ReverseMap();
        }
    }
}
