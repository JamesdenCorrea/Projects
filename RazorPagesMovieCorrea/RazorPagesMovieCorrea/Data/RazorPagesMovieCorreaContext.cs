using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieCorrea.Models;

namespace RazorPagesMovieCorrea.Data
{
    public class RazorPagesMovieCorreaContext : DbContext
    {
        public RazorPagesMovieCorreaContext (DbContextOptions<RazorPagesMovieCorreaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieCorrea.Models.Movie> Movie { get; set; } = default!;
    }
}
