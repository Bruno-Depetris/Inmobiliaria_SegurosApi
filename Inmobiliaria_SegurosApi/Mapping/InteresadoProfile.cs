using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class InteresadoProfile : Profile
    {
        public InteresadoProfile()
        {
            CreateMap<Interesado, InteresadoDto>().ReverseMap();
        }
    }
}
