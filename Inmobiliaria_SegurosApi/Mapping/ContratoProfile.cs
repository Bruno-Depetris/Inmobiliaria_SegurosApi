using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class ContratoProfile : Profile
    {
        public ContratoProfile()
        {
            CreateMap<Contrato, ContratoDto>().ReverseMap();
        }
    }
}
