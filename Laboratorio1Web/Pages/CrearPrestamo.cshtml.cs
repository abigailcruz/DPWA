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
    public class CrearPrestamoModel : PageModel
    {
        private readonly IPrestamoRepository _prestamoRepository;

        public CrearPrestamoModel(IPrestamoRepository prestamoRepository)
        {
            _prestamoRepository = prestamoRepository;
        }
        [BindProperty]
        public Prestamo Prestamo { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _prestamoRepository.Insert(Prestamo);
            return RedirectToPage("./Prestamos");
        }
    }
}
