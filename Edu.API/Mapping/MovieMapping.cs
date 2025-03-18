using AutoMapper;
using Edu.DTO.DTOs.MovieDTOs;
using Edu.Entity.Entities;

namespace Edu.API.Mapping
{
    public class MovieMapping : Profile
    {
        public MovieMapping()
        {
            CreateMap<CreateMovieDTO, Movie>().ReverseMap();
            CreateMap<UpdateMovieDTO, Movie>().ReverseMap();
        }
    }
}
