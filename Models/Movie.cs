using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zently.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        public byte GenreId { get; set; }// Foreign_key

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public byte NumberInStock { get; set; }

    }
}