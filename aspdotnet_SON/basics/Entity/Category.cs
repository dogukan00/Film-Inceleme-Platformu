using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace basics.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
    }
}