using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace ASP.NetWebAPI.MappingProfiles;

/// <summary>
/// Ranobe mapping profile.
/// </summary>
public class RanobeMappingProfile : Profile
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public RanobeMappingProfile()
    {
        CreateMap<Ranobe, RanobeDto>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status!.Name));
    }
}
