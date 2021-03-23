using AutoMapper;
using DTO.Requests.Product;
using DTO.Responses;
using DTO.Responses.Product;
using EFCore.Entities;

namespace PizzaDelivery.Configuration.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Product, ProductResponseDTO>().ReverseMap();
            CreateMap<Product, ProductPostDTO>().ReverseMap();
            CreateMap<Product, ProductResponseDTO>().ReverseMap();
        }
    }
}