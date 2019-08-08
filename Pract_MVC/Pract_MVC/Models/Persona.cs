using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Pract_MVC.Models
{

    public class Persona
    {
        public int codigo { get; set; }

        [Required]
        [StringLength (100,MinimumLength =3)]
        public string nombre { get; set; }
        //de ahi no e cogido n
        [Required]
        [StringLength( 100, MinimumLength = 3)]
        public string apellido { get;set; }

        [Range(18,75)]
        [Required]
        public int edad { get; set; }

        [Display(Name="Fecha de Alta")]//Vista
        [DataType(DataType.Date)]//Darle formato
        [DisplayFormat(DataFormatString="{0:dd-MM-AAAA}",ApplyFormatInEditMode=true)]//Formato de fecha
        [Required]
        public DateTime fecha { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string direccion { get; set; }

    }
}