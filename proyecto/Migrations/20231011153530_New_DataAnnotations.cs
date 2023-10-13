using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesUniversidad.Migrations
{
    /// <inheritdoc />
    public partial class New_DataAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripcion_Curso_CursoId_curso",
                table: "Inscripcion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscripcion_Estudiante_EstudianteId_estudiante",
                table: "Inscripcion");

            migrationBuilder.AlterColumn<int>(
                name: "EstudianteId_estudiante",
                table: "Inscripcion",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId_curso",
                table: "Inscripcion",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripcion_Curso_CursoId_curso",
                table: "Inscripcion",
                column: "CursoId_curso",
                principalTable: "Curso",
                principalColumn: "Id_curso");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripcion_Estudiante_EstudianteId_estudiante",
                table: "Inscripcion",
                column: "EstudianteId_estudiante",
                principalTable: "Estudiante",
                principalColumn: "Id_estudiante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripcion_Curso_CursoId_curso",
                table: "Inscripcion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscripcion_Estudiante_EstudianteId_estudiante",
                table: "Inscripcion");

            migrationBuilder.AlterColumn<int>(
                name: "EstudianteId_estudiante",
                table: "Inscripcion",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CursoId_curso",
                table: "Inscripcion",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripcion_Curso_CursoId_curso",
                table: "Inscripcion",
                column: "CursoId_curso",
                principalTable: "Curso",
                principalColumn: "Id_curso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripcion_Estudiante_EstudianteId_estudiante",
                table: "Inscripcion",
                column: "EstudianteId_estudiante",
                principalTable: "Estudiante",
                principalColumn: "Id_estudiante",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
