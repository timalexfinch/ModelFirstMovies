using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelFirstMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Column(TypeName = "varchar(10)")]
        [StringLength(10, ErrorMessage = "Genre cannot be longer than 10 characters.")]
        [Required(ErrorMessage = "Genre must be specified")]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100, ErrorMessage = "Price must be between £1 and £100")]
        [DataType(DataType.Currency)] // This shows the local currency in the UI
        public decimal Price { get; set; }
    }
}
