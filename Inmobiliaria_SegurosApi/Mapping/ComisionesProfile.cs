using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class ComisionesProfile : Profile
    {
        public ComisionesProfile()
        {
            CreateMap<Comisiones, ComisionesDto>().ReverseMap();
        }
    }
}
