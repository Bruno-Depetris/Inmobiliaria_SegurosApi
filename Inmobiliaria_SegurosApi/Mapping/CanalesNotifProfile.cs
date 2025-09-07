using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class CanalesNotifProfile : Profile
    {
        public CanalesNotifProfile()
        {
            CreateMap<CanalesNotif, CanalesNotifDto>().ReverseMap();
        }
    }
}
