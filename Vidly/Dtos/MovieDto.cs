using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreTypeDto Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }
        
        [Required(ErrorMessage = "Iveskite kieki")]
        [Range(1, 20, ErrorMessage = "Ribos yra 1-20")]
        public byte NumberInStock { get; set; }
        
    }
}