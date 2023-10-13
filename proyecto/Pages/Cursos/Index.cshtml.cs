using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesUniversidad.Data;
using Universidad.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesUniversidad.Pages_Cursos
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesUniversidad.Data.RazorPagesUniversidadContext _context;

        public IndexModel(RazorPagesUniversidad.Data.RazorPagesUniversidadContext context)
        {
            _context = context;
        }

        public IList<Curso> Curso { get;set; } = default!;
        
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
        

        public async Task OnGetAsync()
        {
            // Use LINQ to get a list of genres.
            IQueryable<string> genreQuery = from m in _context.Curso
                                     orderby m.Titulo
                                     select m.Titulo;

            var movies = from m in _context.Curso
                 select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Titulo.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Titulo == MovieGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            Curso = await movies.ToListAsync();
        }

    }
}
