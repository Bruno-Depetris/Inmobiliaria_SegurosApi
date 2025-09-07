using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Tipos_PropiedadProfile : Profile
    {
        public Tipos_PropiedadProfile()
        {
            CreateMap<Tipos_Propiedad, Tipos_PropiedadDto>().ReverseMap();
        }
    }
}
