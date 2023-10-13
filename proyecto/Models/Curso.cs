using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

 

namespace Universidad.Models

{

    public class Curso

    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
       [Key]public int  Id_curso{ get; set; }

        [StringLength(60, MinimumLength = 3)] [Required]
        public string? Titulo { get; set; }

        public int Creditos{ get; set; }


        public ICollection<Inscripcion>? Inscripciones { get; set; }

    }

}