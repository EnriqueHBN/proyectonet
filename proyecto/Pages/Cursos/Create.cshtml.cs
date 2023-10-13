using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesUniversidad.Data;
using Universidad.Models;

namespace RazorPagesUniversidad.Pages_Cursos
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesUniversidad.Data.RazorPagesUniversidadContext _context;

        public CreateModel(RazorPagesUniversidad.Data.RazorPagesUniversidadContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Curso Curso { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Curso == null || Curso == null)
            {
                return Page();
            }

            _context.Curso.Add(Curso);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
