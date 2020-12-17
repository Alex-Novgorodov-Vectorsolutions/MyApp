using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfilers : Profile
    {
        public AutoMapperProfilers()
        {
            CreateMap<AppUser, MemberDto>();
            CreateMap<Photo, PhotoDto>();
        }
    }
}