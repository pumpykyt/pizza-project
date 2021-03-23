using AutoMapper;
using DTO.Responses;
using EFCore.Entities;

namespace PizzaDelivery.Configuration.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}