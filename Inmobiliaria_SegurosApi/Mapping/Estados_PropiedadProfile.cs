using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Estados_PropiedadProfile : Profile
    {
        public Estados_PropiedadProfile()
        {
            CreateMap<Estados_Propiedad, Estados_PropiedadDto>().ReverseMap();
        }
    }
}
