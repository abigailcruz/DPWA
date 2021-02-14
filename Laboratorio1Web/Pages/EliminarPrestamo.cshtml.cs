using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio1DATA.Interfaces;
using Laboratorio1Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Laboratorio1Web.Pages
{
    public class EliminarPrestamoModel : PageModel
    {
        private readonly IPrestamoRepository _prestamoRepository;

        public EliminarPrestamoModel(IPrestamoRepository prestamoRepository)
        {
            _prestamoRepository = prestamoRepository;
        }

        [BindProperty]
        public Prestamo Prestamo { get; set; }

        public IActionResult OnGet(int Id)
        {
            Prestamo = _prestamoRepository.GetById(Id);
            if (Prestamo == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var PrestamoToDelete = _prestamoRepository.GetById(Id);
            if (PrestamoToDelete == null)

                return NotFound();

            PrestamoToDelete.CodigoPrestamo = Prestamo.CodigoPrestamo;
            PrestamoToDelete.FechaPrestamo = Prestamo.FechaPrestamo;
            PrestamoToDelete.FechaDevolucion = Prestamo.FechaDevolucion;
            PrestamoToDelete.ClienteID = Prestamo.ClienteID;
            PrestamoToDelete.PeliculaID = Prestamo.PeliculaID;

            _prestamoRepository.Delete(PrestamoToDelete);
            return RedirectToPage("./Prestamos");
        }
    }
}
