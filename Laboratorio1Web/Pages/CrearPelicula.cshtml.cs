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
    public class CrearPeliculaModel : PageModel
    {
        private readonly IPeliculaRepository _peliculaRepository;

        public CrearPeliculaModel(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }
        [BindProperty]
        public Pelicula Pelicula { get; set; }
        public void OnGet()
        {
         
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            
            _peliculaRepository.Insert(Pelicula);
            return RedirectToPage("./Peliculas");
        }
    }
}

    