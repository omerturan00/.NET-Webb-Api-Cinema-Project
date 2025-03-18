using Edu.Entity.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Entity.Entities
{
    public class ShowTime : BaseEntity
    {
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public DateTime Showtime { get; set; }
    }
}
