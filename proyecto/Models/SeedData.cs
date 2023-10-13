using Microsoft.EntityFrameworkCore;
using RazorPagesUniversidad.Data;
using System;
using System.Linq;
using Universidad.Models;

namespace RazorPagesUniversidad.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesUniversidadContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesUniversidadContext>>()))
            {
                if (context == null || context.Curso == null)
                {
                    throw new ArgumentNullException("Null RazorPagesUniversidadContext");
                }

                // Buscar si hay películas.
                if (context.Curso.Any())
                {
                    return; // La base de datos ya ha sido poblada.
                }

                context.Curso.AddRange(
                    new Curso
                    {
                       Id_curso = 1,
                       Titulo = "Matematicas Avanzadas",
                       Creditos = 10
                    },
                    new Curso
                    {
                        Id_curso = 2,
                       Titulo = "Programacion Avanzada",
                       Creditos = 10
                    },
                    new Curso
                    {
                        Id_curso = 3,
                       Titulo = "Humanismo",
                       Creditos = 10
                    },
                    new Curso
                    {
                      Id_curso = 4,
                       Titulo = "Desarrollo en entornos virtuales",
                       Creditos = 10
                    }
                );

                context.SaveChanges();

                  var students = new Estudiante[]
                    {
                    new Estudiante{Id_estudiante=1,Apellidos="Alexander",Nombres="Alexander",Fecha_inscripcion=DateTime.Parse("2019-09-01")},
                    new Estudiante{Id_estudiante=2,Apellidos="Alonso",Nombres="Leon",Fecha_inscripcion=DateTime.Parse("2017-09-01")},
                    new Estudiante{Id_estudiante=3,Apellidos="Anand",Nombres="Paez",Fecha_inscripcion=DateTime.Parse("2018-09-01")},
                    new Estudiante{Id_estudiante=4,Apellidos="Barzdukas",Nombres="Leo",Fecha_inscripcion=DateTime.Parse("2017-09-01")},
                    new Estudiante{Id_estudiante=5,Apellidos="Li",Nombres="Jae",Fecha_inscripcion=DateTime.Parse("2017-09-01")},
                    new Estudiante{Id_estudiante=6,Apellidos="Justice",Nombres="Nils",Fecha_inscripcion=DateTime.Parse("2016-09-01")},
                    new Estudiante{Id_estudiante=7,Apellidos="Norman",Nombres="Uri",Fecha_inscripcion=DateTime.Parse("2018-09-01")},
                    new Estudiante{Id_estudiante=8,Apellidos="Olivetto",Nombres="Pablo",Fecha_inscripcion=DateTime.Parse("2019-09-01")}
                    };

                context.Estudiante.AddRange(students);
                context.SaveChanges();

                var inscripciones = new Inscripcion[]
                {
                new Inscripcion{Id_curso = 1050,Id_estudiante = 1, Grado = Grado.A},
                new Inscripcion{Id_curso = 4022,Id_estudiante = 2, Grado = Grado.C},
                new Inscripcion{Id_curso = 4041,Id_estudiante = 3, Grado = Grado.B},
                new Inscripcion{Id_curso = 1045,Id_estudiante = 4, Grado = Grado.B},
                new Inscripcion{Id_curso = 3141,Id_estudiante = 5, Grado = Grado.F},
                new Inscripcion{Id_curso = 2021,Id_estudiante = 6, Grado = Grado.F},
                new Inscripcion{Id_curso = 1050,Id_estudiante = 7, Grado = Grado.A},
                new Inscripcion{Id_curso = 1050,Id_estudiante = 8, Grado = Grado.B},
                new Inscripcion{Id_curso = 4022,Id_estudiante = 9, Grado = Grado.F},
                new Inscripcion{Id_curso = 4041,Id_estudiante = 10, Grado = Grado.C},
                new Inscripcion{Id_curso = 1045,Id_estudiante = 11, Grado = Grado.D},
                new Inscripcion{Id_curso = 3141,Id_estudiante = 12, Grado = Grado.A},
                };

            context.Inscripcion.AddRange(inscripciones);
            context.SaveChanges();

            }
        }
    }
}

