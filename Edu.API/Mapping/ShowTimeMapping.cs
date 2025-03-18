using AutoMapper;
using Edu.DTO.DTOs.ShowTimeDTOs;
using Edu.Entity.Entities;

namespace Edu.API.Mapping
{
    public class ShowTimeMapping : Profile
    {
        public ShowTimeMapping()
        {
            CreateMap<CreateShowtimeDTO, ShowTime>().ReverseMap();
            CreateMap<UpdateShowtimeDTO, ShowTime>().ReverseMap();
        }
    }
}
