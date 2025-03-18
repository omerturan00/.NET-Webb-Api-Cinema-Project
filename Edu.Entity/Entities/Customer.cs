using Edu.Entity.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Entity.Entities
{
    public class Customer : BaseEntity
    {
        public string NameSurname { get; set; }
        public string Phone { get; set; }
    }
}
