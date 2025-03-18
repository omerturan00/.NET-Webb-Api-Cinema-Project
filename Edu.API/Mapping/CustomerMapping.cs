using AutoMapper;
using Edu.DTO.DTOs.CustomerDTOs;
using Edu.Entity.Entities;

namespace Edu.API.Mapping
{
    public class CustomerMapping : Profile
    {
        public CustomerMapping()
        {
            CreateMap<CreateCustomerDTO, Customer>().ReverseMap();
            CreateMap<UpdateCustomerDTO, Customer>().ReverseMap();
        }
    }
}
