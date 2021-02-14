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
    public class PrestamosModel : PageModel
    {
            private readonly IPrestamoRepository _prestamoRepository;
            public PrestamosModel(IPrestamoRepository prestamoRepository)
            {
                _prestamoRepository = prestamoRepository;
            }

            [BindProperty]
            public IEnumerable<Prestamo> Prestamos { get; set; }
            public IActionResult OnGet()
            {
                Prestamos = _prestamoRepository.List();
                return Page();
            }
        
    }
}
