using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DTO.DTOs.CustomerDTOs
{
    public class UpdateCustomerDTO
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
    }
}
