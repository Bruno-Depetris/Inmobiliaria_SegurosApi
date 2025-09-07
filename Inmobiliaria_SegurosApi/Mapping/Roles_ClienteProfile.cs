using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Roles_ClienteProfile : Profile
    {
        public Roles_ClienteProfile()
        {
            CreateMap<Roles_Cliente, Roles_ClienteDto>().ReverseMap();
        }
    }
}
