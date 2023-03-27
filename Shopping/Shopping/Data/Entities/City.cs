﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        //Data Annotations
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }


        [JsonIgnore]
        public State State { get; set; }

        public ICollection<User> Users { get; set; }
        

    }
}
