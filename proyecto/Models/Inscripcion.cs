using System.ComponentModel.DataAnnotations;

namespace Universidad.Models{
    public enum Grado{
        A,B,C,D,E,F
    }
    public class Inscripcion{
        [Key]public int Id_inscripcion{get;set;}
        public int Id_curso{get;set;}
        public int Id_estudiante{get;set;}
        [DisplayFormat(NullDisplayText ="Ningun grado")]
        public Grado? Grado{get;set;}
        public Curso? Curso{get;set;}
        public Estudiante? Estudiante{get;set;}
        //coloque un signo de interrogacion en Grado y Curso (ya estaba en Grado)
    }
}