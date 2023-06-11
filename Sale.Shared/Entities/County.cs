using System.ComponentModel.DataAnnotations;

namespace Sale.Shared.Entities
{
    public class County
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El campo es {0} obligatorio")]
        [MaxLength(100, ErrorMessage = "el Campo {0} no puede tener mas de {1} caracteres")]
        public string Name { get; set; } = null!;


    }
}
