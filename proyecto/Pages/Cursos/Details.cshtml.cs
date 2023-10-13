using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesUniversidad.Data;
using Universidad.Models;

namespace RazorPagesUniversidad.Pages_Cursos
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesUniversidad.Data.RazorPagesUniversidadContext _context;

        public DetailsModel(RazorPagesUniversidad.Data.RazorPagesUniversidadContext context)
        {
            _context = context;
        }

      public Curso Curso { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Curso == null)
            {
                return NotFound();
            }

            var curso = await _context.Curso.FirstOrDefaultAsync(m => m.Id_curso == id);
            if (curso == null)
            {
                return NotFound();
            }
            else 
            {
                Curso = curso;
            }
            return Page();
        }
    }
}
