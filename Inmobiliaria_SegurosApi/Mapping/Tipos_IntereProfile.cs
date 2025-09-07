using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Tipos_IntereProfile : Profile
    {
        public Tipos_IntereProfile()
        {
            CreateMap<Tipos_Intere, Tipos_IntereDto>().ReverseMap();
        }
    }
}
