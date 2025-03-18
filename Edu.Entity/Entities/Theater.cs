using Edu.Entity.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Entity.Entities
{
    public class Theater : BaseEntity
    {
        public string Name { get; set; }
        public int SeatCapacity { get; set; }
    }
}
