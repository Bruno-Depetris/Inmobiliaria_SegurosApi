using AutoMapper;
using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.DTOs;

namespace Inmobiliaria_SegurosApi.Mapping
{
    public class Tipos_DocumentoProfile : Profile
    {
        public Tipos_DocumentoProfile()
        {
            CreateMap<Tipos_Documento, Tipos_DocumentoDto>().ReverseMap();
        }
    }
}
