using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Estados_EnvioProfile : Profile
    {
        public Estados_EnvioProfile()
        {
            CreateMap<Estados_Envio, Estados_EnvioDto>().ReverseMap();
        }
    }
}
