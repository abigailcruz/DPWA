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
    public class EditarPrestamoModel : PageModel
    {
        private readonly IPrestamoRepository _prestamoRepository;

        public EditarPrestamoModel(IPrestamoRepository prestamoRepository)
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

            var PrestamoToUpdate = _prestamoRepository.GetById(Id);
            if (PrestamoToUpdate == null)

                return NotFound();

            PrestamoToUpdate.CodigoPrestamo = Prestamo.CodigoPrestamo;
            PrestamoToUpdate.FechaPrestamo = Prestamo.FechaPrestamo;
            PrestamoToUpdate.FechaDevolucion = Prestamo.FechaDevolucion;
            PrestamoToUpdate.ClientID = Prestamo.ClientID;
            PrestamoToUpdate.PeliculaID = Prestamo.PeliculaID;

            _prestamoRepository.Update(PrestamoToUpdate);
            return RedirectToPage("./Prestamos");
        }
    }
}
