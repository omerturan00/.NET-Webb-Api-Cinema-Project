using AutoMapper;
using Edu.Business.Abstract;
using Edu.DTO.DTOs.MovieDTOs;
using Edu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController(IGenericService<Movie> _movieService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _movieService.TGetList();
            return Ok(values);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            var value = _movieService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(CreateMovieDTO createMovieDTO)
        {
            var newValue = _mapper.Map<Movie>(createMovieDTO);
            _movieService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(UpdateMovieDTO updateMovieDTO)
        {
            var value = _mapper.Map<Movie>(updateMovieDTO);
            _movieService.TUpdate(value);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _movieService.TDelete(id);
            return Ok();
        }

    }

}
