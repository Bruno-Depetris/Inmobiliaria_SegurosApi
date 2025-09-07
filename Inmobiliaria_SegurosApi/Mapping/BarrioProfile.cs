using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class BarrioProfile : Profile
    {
        public BarrioProfile()
        {
            CreateMap<Barrio, BarrioDto>().ReverseMap();
        }
    }
}
