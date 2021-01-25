using AutoMapper;
using DotnetCoreWebAPI.Dtos;
using DotnetCoreWebAPI.Models;

namespace DotnetCoreWebAPI.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserUpdateDto>();
        }
    }
}
