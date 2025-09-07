using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Tipos_SeguroProfile : Profile
    {
        public Tipos_SeguroProfile()
        {
            CreateMap<Tipos_Seguro, Tipos_SeguroDto>().ReverseMap();
        }
    }
}
