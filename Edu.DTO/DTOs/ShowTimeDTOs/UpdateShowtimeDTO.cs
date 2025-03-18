using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DTO.DTOs.ShowTimeDTOs
{
    public class UpdateShowtimeDTO
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public DateTime Showtime { get; set; }
    }
}
