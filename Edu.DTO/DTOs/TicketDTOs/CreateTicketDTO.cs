using Edu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DTO.DTOs.TicketDTOs
{
    public class CreateTicketDTO
    {

        public int CustomerId { get; set; }
        public int ShowTimeId { get; set; }
        public string SeatNumber { get; set; }
        public decimal Price { get; set; }
        public int PaymentType { get; set; }
    }
}
