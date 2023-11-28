using AutoMapper;
using RestEncuestasAPI.Data.DTO;
using RestEncuestasAPI.Data.Entities;

namespace RestEncuestasAPI.DtosAutomapperProfiles
{
    public class EncuestasProfile : Profile
    {
        public EncuestasProfile()
        {
            CreateMap<EncuestaDto, Encuesta>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.TipoEncuesta, opt => opt.MapFrom(src => src.TipoEncuesta));
            CreateMap<Encuesta, EncuestaDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.TipoEncuesta, opt => opt.MapFrom(src => src.TipoEncuesta));
        }
    }
}
