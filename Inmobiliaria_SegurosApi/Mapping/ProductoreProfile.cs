using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class ProductoreProfile : Profile
    {
        public ProductoreProfile()
        {
            CreateMap<Productore, ProductoreDto>().ReverseMap();
        }
    }
}
