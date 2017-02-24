using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly_1.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(225)]
        public string Name { get; set; }

        [Required]
        public Genre  Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte NumberInStock { get; set; }
    }
}