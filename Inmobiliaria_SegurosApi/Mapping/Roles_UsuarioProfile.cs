using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Roles_UsuarioProfile : Profile
    {
        public Roles_UsuarioProfile()
        {
            CreateMap<Roles_Usuario, Roles_UsuarioDto>().ReverseMap();
        }
    }
}
