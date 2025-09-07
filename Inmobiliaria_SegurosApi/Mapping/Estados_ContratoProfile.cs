using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Estados_ContratoProfile : Profile
    {
        public Estados_ContratoProfile()
        {
            CreateMap<Estados_Contrato, Estados_ContratoDto>().ReverseMap();
        }
    }
}
