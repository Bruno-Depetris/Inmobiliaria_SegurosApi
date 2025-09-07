using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class MonedaProfile : Profile
    {
        public MonedaProfile()
        {
            CreateMap<Moneda, MonedaDto>().ReverseMap();
        }
    }
}
