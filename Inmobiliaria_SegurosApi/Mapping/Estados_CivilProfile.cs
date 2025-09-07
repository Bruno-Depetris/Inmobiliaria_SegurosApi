using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Estados_CivilProfile : Profile
    {
        public Estados_CivilProfile()
        {
            CreateMap<Estados_Civil, Estados_CivilDto>().ReverseMap();
        }
    }
}
