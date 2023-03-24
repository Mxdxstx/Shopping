﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        //Data Annotations
        [Display(Name = "Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public int CountryId { get; set; }


    }

}
