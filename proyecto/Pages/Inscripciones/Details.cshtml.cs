using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesUniversidad.Data;
using Universidad.Models;

namespace RazorPagesUniversidad.Pages_Inscripciones
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesUniversidad.Data.RazorPagesUniversidadContext _context;

        public DetailsModel(RazorPagesUniversidad.Data.RazorPagesUniversidadContext context)
        {
            _context = context;
        }

      public Inscripcion Inscripcion { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Inscripcion == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.Inscripcion.FirstOrDefaultAsync(m => m.Id_inscripcion == id);
            if (inscripcion == null)
            {
                return NotFound();
            }
            else 
            {
                Inscripcion = inscripcion;
            }
            return Page();
        }
    }
}
