using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DTO.DTOs.TheaterDTOs
{
    public class UpdateTheaterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatCapacity { get; set; }
    }
}
