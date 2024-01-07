using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using basics.Entity;

namespace basics.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext>options):base(options){
            
        }

        public DbSet<Movie>Movies{ get; set; }
        public DbSet<Category>Categories{ get; set; }
    }
}