using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        //Data Annotations
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage ="El campo {0} no debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public string Name { get; set; }

    }
}
