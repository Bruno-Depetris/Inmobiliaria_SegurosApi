using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Tipos_DestinatarioProfile : Profile
    {
        public Tipos_DestinatarioProfile()
        {
            CreateMap<Tipos_Destinatario, Tipos_DestinatarioDto>().ReverseMap();
        }
    }
}
