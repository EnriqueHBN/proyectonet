using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesUniversidad.Data;
using Universidad.Models;

namespace RazorPagesUniversidad.Pages_Estudiantes
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesUniversidad.Data.RazorPagesUniversidadContext _context;

        public DeleteModel(RazorPagesUniversidad.Data.RazorPagesUniversidadContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Estudiante Estudiante { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Estudiante == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante.FirstOrDefaultAsync(m => m.Id_estudiante == id);

            if (estudiante == null)
            {
                return NotFound();
            }
            else 
            {
                Estudiante = estudiante;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Estudiante == null)
            {
                return NotFound();
            }
            var estudiante = await _context.Estudiante.FindAsync(id);

            if (estudiante != null)
            {
                Estudiante = estudiante;
                _context.Estudiante.Remove(Estudiante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
