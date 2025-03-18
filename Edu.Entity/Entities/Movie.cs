using Edu.Entity.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Entity.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
