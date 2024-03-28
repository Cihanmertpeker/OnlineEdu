using AutoMapper;
using OnlineEdu.Dto.Dtos.SubscriberDto;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SubscribeMapping:Profile
    {
        public SubscribeMapping()
        {
            CreateMap<CreateSubscriberDto,Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDto,Subscriber>().ReverseMap();
        }
    }
}
