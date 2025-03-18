using AutoMapper;
using Edu.DTO.DTOs.TheaterDTOs;
using Edu.Entity.Entities;

namespace Edu.API.Mapping
{
    public class TheaterMapping : Profile
    {
        public TheaterMapping()
        {
            CreateMap<CreateTheaterDTO, Theater>().ReverseMap();
            CreateMap<UpdateTheaterDTO, Theater>().ReverseMap();
        }   
    }
}
