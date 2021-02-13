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
    public class PeliculasModel : PageModel
    {
        private readonly IPeliculaRepository _peliculaRepository;
        public PeliculasModel(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        [BindProperty]
        public IEnumerable<Pelicula> Peliculas { get; set; }
        public IActionResult OnGet()
        {
            Peliculas = _peliculaRepository.List();
            return Page();
        }
    }
}
