using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class PropiedadeProfile : Profile
    {
        public PropiedadeProfile()
        {
            CreateMap<Propiedade, PropiedadeDto>().ReverseMap();
        }
    }
}
