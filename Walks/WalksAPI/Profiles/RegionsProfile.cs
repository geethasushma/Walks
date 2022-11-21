using AutoMapper;

namespace WalksAPI.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.domain.Region, Models.DTO.Region>()
                .ForMember(dest =>dest.Id, options=>options.MapFrom(src=>src.Id));
        }

    }
}
