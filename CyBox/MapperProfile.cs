using AutoMapper;
using CyBox.Data.Entities;
using CyBox.Domain.Dto;

namespace CyBox
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserLoginDto, User>();
        }
    }
}
