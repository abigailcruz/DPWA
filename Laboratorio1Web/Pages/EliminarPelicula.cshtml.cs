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
    public class EliminarPeliculaModel : PageModel
    {
        private readonly IPeliculaRepository _peliculaRepository;

        public EliminarPeliculaModel(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        [BindProperty]
        public Pelicula Pelicula { get; set; }

        public IActionResult OnGet(int Id)
        {
            Pelicula = _peliculaRepository.GetById(Id);
            if (Pelicula == null)
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

            var PeliculaToDelete = _peliculaRepository.GetById(Id);
            if (PeliculaToDelete == null)

                return NotFound();

            
            PeliculaToDelete.Codigo = Pelicula.Codigo;
            PeliculaToDelete.Titulo = Pelicula.Titulo;
            PeliculaToDelete.Año = Pelicula.Año;
            PeliculaToDelete.Duracion = Pelicula.Duracion;

            _peliculaRepository.Delete(PeliculaToDelete);
            return RedirectToPage("./Peliculas");
        }
    }
}
