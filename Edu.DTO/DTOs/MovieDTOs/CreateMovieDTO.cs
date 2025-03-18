using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DTO.DTOs.MovieDTOs
{
    public class CreateMovieDTO
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
