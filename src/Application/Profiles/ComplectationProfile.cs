using Application.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles;

public class ComplectationProfile : Profile
{
    public ComplectationProfile()
    {
        CreateMap<ComplectationDto, Complectation>()
            .ForMember(e => e.Groups, o => o.Ignore());
    }
}
