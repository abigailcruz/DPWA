using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laboratorio1Models
{
   public class Cliente : EntityBase
    {
        [Required(ErrorMessage = "El campo codigo no puede estar vacio")]
        [Display(Name = "Codigo de Cliente")]
        public string CodigoCliente { get; set; }
        [Required(ErrorMessage = "El campo nombre no puede estar vacio")]
        [Display(Name = "Nombre de Cliente")]
        public string NombreCliente { get; set; }
        [Required(ErrorMessage = "El campo apellido no puede estar vacio")]
        [Display(Name = "Apellido de Cliente")]
        public string ApellidoCliente { get; set; }
        [Required(ErrorMessage = "El campo direccion no puede estar vacio")]
        [Display(Name = "Direccion de Cliente")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo Telefono no puede estar vacio")]
        [Display(Name = "Telefono de Cliente")]
        public string Telefono { get; set; }

        //public ICollection<Prestamo> Prestamos { get; set; }

    }
}
