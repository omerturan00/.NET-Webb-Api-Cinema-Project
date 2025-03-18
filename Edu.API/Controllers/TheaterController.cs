using AutoMapper;
using Edu.Business.Abstract;
using Edu.DTO.DTOs.TheaterDTOs;
using Edu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterController(IGenericService<Theater> _theaterService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _theaterService.TGetList();
            return Ok(values);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            var value = _theaterService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(CreateTheaterDTO createTheaterDTO)
        {
            var newValue = _mapper.Map<Theater>(createTheaterDTO);
            _theaterService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(UpdateTheaterDTO updateTheaterDTO)
        {
            var value = _mapper.Map<Theater>(updateTheaterDTO);
            _theaterService.TUpdate(value);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _theaterService.TDelete(id);
            return Ok();
        }

    }
}
