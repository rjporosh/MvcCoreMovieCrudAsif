using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class MvcMovieContext : DbContext
    {
        //protected override void OnConfiguring()
        //{
            
        //}
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
