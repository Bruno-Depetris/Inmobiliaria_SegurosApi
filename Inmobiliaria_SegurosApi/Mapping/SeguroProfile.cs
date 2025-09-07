using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class SeguroProfile : Profile
    {
        public SeguroProfile()
        {
            CreateMap<Seguro, SeguroDto>().ReverseMap();
        }
    }
}
