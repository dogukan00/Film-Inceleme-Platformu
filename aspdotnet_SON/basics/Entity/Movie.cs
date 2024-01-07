using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace basics.Entity
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        public string ?ShortDescription { get; set; }
        [MaxLength(500)]
        public string ?Description { get; set; }
        public string ?ImageUrl { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}