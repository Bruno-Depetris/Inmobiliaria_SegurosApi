using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Log_ActividadeProfile : Profile
    {
        public Log_ActividadeProfile()
        {
            CreateMap<Log_Actividade, Log_ActividadeDto>().ReverseMap();
        }
    }
}
