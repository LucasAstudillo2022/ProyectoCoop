using System;
using System.ComponentModel.DataAnnotations;


namespace ProyectoServiCoop.Models
{
    public class Servi
    {
        [Display(Name = "Id")]

        public int ID { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "La Marca es obligatorio")]
        public string marca { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "El tipo es obligatorio")]
        public string tipo { get; set; }

        [Display(Name = "Fecha de Realizacion")]
        public DateTime fecharealizada { get; set; }

        [Display(Name = "Kilometraje")]
        public int km { get; set; }

        [Display(Name = "Proximo servi(km)")]
        public int proxservi { get; set; }

        [Display(Name ="Realizado")]
        public string realizado { get; set; }    
    }
}

