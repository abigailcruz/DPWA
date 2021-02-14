using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laboratorio1Models
{
    public class Pelicula : EntityBase
    {
        [Required (ErrorMessage= "El campo codigo no puede estar vacio")]
        [Display(Name = "Codigo de Pelicula")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo nombre no puede estar vacio")]
        [Display(Name = "Nombre de Pelicula")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El campo Año no puede estar vacio")]
        public int Año { get; set; }
        [Required(ErrorMessage = "El campo Duracion no puede estar vacio")]
        public string Duracion { get; set; }

        /*//relacion
        public ICollection<Prestamo> Prestamos { get; set; }*/
    }
}
