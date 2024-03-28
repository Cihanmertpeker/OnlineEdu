using AutoMapper;
using OnlineEdu.Dto.Dtos.SocialMediaDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<CreateSocialMediaDto,SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDto,SocialMedia>().ReverseMap();
        }
    }
}
