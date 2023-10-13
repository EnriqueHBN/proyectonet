using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesUniversidad.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id_curso = table.Column<int>(type: "INTEGER", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Creditos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id_curso);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id_estudiante = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    Nombres = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha_inscripcion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id_estudiante);
                });

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    Id_inscripcion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id_curso = table.Column<int>(type: "INTEGER", nullable: false),
                    Id_estudiante = table.Column<int>(type: "INTEGER", nullable: false),
                    Grado = table.Column<int>(type: "INTEGER", nullable: true),
                    CursoId_curso = table.Column<int>(type: "INTEGER", nullable: false),
                    EstudianteId_estudiante = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.Id_inscripcion);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Curso_CursoId_curso",
                        column: x => x.CursoId_curso,
                        principalTable: "Curso",
                        principalColumn: "Id_curso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Estudiante_EstudianteId_estudiante",
                        column: x => x.EstudianteId_estudiante,
                        principalTable: "Estudiante",
                        principalColumn: "Id_estudiante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_CursoId_curso",
                table: "Inscripcion",
                column: "CursoId_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_EstudianteId_estudiante",
                table: "Inscripcion",
                column: "EstudianteId_estudiante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
