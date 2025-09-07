using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Estados_SeguroProfile : Profile
    {
        public Estados_SeguroProfile()
        {
            CreateMap<Estados_Seguro, Estados_SeguroDto>().ReverseMap();
        }
    }
}
