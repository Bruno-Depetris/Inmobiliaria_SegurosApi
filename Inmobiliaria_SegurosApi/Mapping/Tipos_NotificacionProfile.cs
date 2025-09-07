using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Tipos_NotificacionProfile : Profile
    {
        public Tipos_NotificacionProfile()
        {
            CreateMap<Tipos_Notificacion, Tipos_NotificacionDto>().ReverseMap();
        }
    }
}
