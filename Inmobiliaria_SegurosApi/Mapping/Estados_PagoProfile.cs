using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Estados_PagoProfile : Profile
    {
        public Estados_PagoProfile()
        {
            CreateMap<Estados_Pago, Estados_PagoDto>().ReverseMap();
        }
    }
}
