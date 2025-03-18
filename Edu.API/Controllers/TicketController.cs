using AutoMapper;
using Edu.Business.Abstract;
using Edu.DTO.DTOs.TicketDTOs;
using Edu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController(IGenericService<Ticket> _ticketController, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _ticketController.TGetList();
            return Ok(values);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            var value = _ticketController.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(CreateTicketDTO createTicketDTO)
        {
            var newValue = _mapper.Map<Ticket>(createTicketDTO);
            _ticketController.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(UpdateTicketDTO updateTicketDTO)
        {
            var value = _mapper.Map<Ticket>(updateTicketDTO);
            _ticketController.TUpdate(value);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")] 
        public IActionResult Delete(int id)
        {
            _ticketController.TDelete(id);
            return Ok();
        }

    }

}
