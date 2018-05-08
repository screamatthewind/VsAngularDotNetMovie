using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VsAngularDotNetMovie;

namespace VsAngularDotNetMovie.Models
{
    public class VsAngularDotNetMovieContext : DbContext
    {
        public VsAngularDotNetMovieContext (DbContextOptions<VsAngularDotNetMovieContext> options)
            : base(options)
        {
        }

        public DbSet<VsAngularDotNetMovie.Movie> Movie { get; set; }
    }
}
