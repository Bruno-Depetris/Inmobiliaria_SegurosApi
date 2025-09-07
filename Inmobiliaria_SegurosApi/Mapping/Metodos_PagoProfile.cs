using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Metodos_PagoProfile : Profile
    {
        public Metodos_PagoProfile()
        {
            CreateMap<Metodos_Pago, Metodos_PagoDto>().ReverseMap();
        }
    }
}
