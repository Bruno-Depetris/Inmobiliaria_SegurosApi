using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Sesiones_JWTProfile : Profile
    {
        public Sesiones_JWTProfile()
        {
            CreateMap<Sesiones_JWT, Sesiones_JWTDto>().ReverseMap();
        }
    }
}
