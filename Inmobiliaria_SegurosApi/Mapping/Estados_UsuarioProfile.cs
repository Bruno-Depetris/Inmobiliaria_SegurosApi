using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Estados_UsuarioProfile : Profile
    {
        public Estados_UsuarioProfile()
        {
            CreateMap<Estados_Usuario, Estados_UsuarioDto>().ReverseMap();
        }
    }
}
