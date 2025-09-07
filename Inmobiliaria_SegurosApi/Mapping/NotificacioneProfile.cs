using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class NotificacioneProfile : Profile
    {
        public NotificacioneProfile()
        {
            CreateMap<Notificacione, NotificacioneDto>().ReverseMap();
        }
    }
}
