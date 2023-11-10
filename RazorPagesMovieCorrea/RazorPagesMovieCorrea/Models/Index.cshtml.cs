using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieCorrea.Data;

namespace RazorPagesMovieCorrea.Models
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieCorrea.Data.RazorPagesMovieCorreaContext _context;

        public IndexModel(RazorPagesMovieCorrea.Data.RazorPagesMovieCorreaContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
