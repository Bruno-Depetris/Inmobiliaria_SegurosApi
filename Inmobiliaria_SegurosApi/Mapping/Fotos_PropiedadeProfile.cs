using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Fotos_PropiedadeProfile : Profile
    {
        public Fotos_PropiedadeProfile()
        {
            CreateMap<Fotos_Propiedade, Fotos_PropiedadeDto>().ReverseMap();
        }
    }
}
