using System.ComponentModel.DataAnnotations;

namespace LibraryTravel.Common.Models
{
    public class Authors
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Display(Name = "Nombres")]
        public string Names { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Display(Name = "Apellidos")]
        public string LastNames { get; set; }
    }
}
