using AutoMapper;
using Edu.Business.Abstract;
using Edu.DTO.DTOs.ShowTimeDTOs;
using Edu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimeController(IGenericService<ShowTime> _showtimeService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _showtimeService.TGetList();
            return Ok(values);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            var value = _showtimeService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(CreateShowtimeDTO createShowTimeDTO)
        {
            var newValue = _mapper.Map<ShowTime>(createShowTimeDTO);
            _showtimeService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(UpdateShowtimeDTO updateShowTimeDTO)
        {
            var value = _mapper.Map<ShowTime>(updateShowTimeDTO);
            _showtimeService.TUpdate(value);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _showtimeService.TDelete(id);
            return Ok();
        }

    }

}
