using System.ComponentModel.DataAnnotations;

namespace Universidad.Models{
    public class Estudiante{
        [Key]public int Id_estudiante{get;set;}

        [StringLength(60, MinimumLength = 3)] [Required]
        public string? Apellidos {get;set;}

        [StringLength(60, MinimumLength = 3)] [Required]
        public string? Nombres {get;set;}

        [DataType(DataType.Date)]
        public DateTime Fecha_inscripcion{get;set;}

        public ICollection<Inscripcion>?Inscripciones{get;set;}

        
    }
}