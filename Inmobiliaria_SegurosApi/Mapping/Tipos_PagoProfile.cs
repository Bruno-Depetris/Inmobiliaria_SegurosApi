using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Tipos_PagoProfile : Profile
    {
        public Tipos_PagoProfile()
        {
            CreateMap<Tipos_Pago, Tipos_PagoDto>().ReverseMap();
        }
    }
}
