using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DTO.DTOs.MovieDTOs
{
    public class UpdateMovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
