using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Variables_ImpositivaProfile : Profile
    {
        public Variables_ImpositivaProfile()
        {
            CreateMap<Variables_Impositiva, Variables_ImpositivaDto>().ReverseMap();
        }
    }
}
