using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Universidad.Models;

namespace RazorPagesUniversidad.Data
{
    public class RazorPagesUniversidadContext : DbContext
    {
        public RazorPagesUniversidadContext (DbContextOptions<RazorPagesUniversidadContext> options)
            : base(options)
        {
        }

        public DbSet<Universidad.Models.Estudiante> Estudiante { get; set; } = default!;

        public DbSet<Universidad.Models.Curso> Curso { get; set; } = default!;

        public DbSet<Universidad.Models.Inscripcion> Inscripcion { get; set; } = default!;
    }
}
