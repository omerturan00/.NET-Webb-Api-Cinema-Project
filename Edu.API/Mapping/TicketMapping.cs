using AutoMapper;
using Edu.DTO.DTOs.TicketDTOs;
using Edu.Entity.Entities;

namespace Edu.API.Mapping
{
    public class TicketMapping : Profile
    {
        public TicketMapping()
        {
            CreateMap<CreateTicketDTO, Ticket>().ReverseMap();
            CreateMap<UpdateTicketDTO, Ticket>().ReverseMap();
        }
    }
}
