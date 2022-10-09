using System;
using System.ComponentModel.DataAnnotations;


namespace ProyectoServiCoop.Models1
{
    public class Controle
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
        [Required(ErrorMessage = "Los Kilometros es obligatorio")]
        public int km { get; set; }

        [Display(Name = "Comentario")]
        [Required(ErrorMessage = "El Comentario es obligatorio")]
        public string opinion { get; set; }

        [Display(Name = "Realizado por: ")]
        public string realizado { get; set; }

        [Display(Name = "Supervisado por: ")]
        public string supervisor { get; set; }


    }
}

