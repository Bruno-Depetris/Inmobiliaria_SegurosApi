using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
        }
    }
}
