using AutoMapper;
using Edu.Business.Abstract;
using Edu.DTO.DTOs.CustomerDTOs;
using Edu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(IGenericService<Customer> _customerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _customerService.TGetList();
            return Ok(values);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            var value = _customerService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(CreateCustomerDTO createCustomerDTO)
        {
            var newValue = _mapper.Map<Customer>(createCustomerDTO);
            _customerService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(UpdateCustomerDTO updateCustomerDTO)
        {
            var value = _mapper.Map<Customer>(updateCustomerDTO);
            _customerService.TUpdate(value);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _customerService.TDelete(id);
            return Ok();
        }

    }
}
