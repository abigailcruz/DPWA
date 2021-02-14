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
    public class EditarPeliculaModel : PageModel
    {

        private readonly IPeliculaRepository _peliculaRepository;

        public EditarPeliculaModel(IPeliculaRepository peliculaRepository)
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
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var PeliculaToUpdate = _peliculaRepository.GetById(Id);
            if (PeliculaToUpdate == null)
           
            return NotFound();

            PeliculaToUpdate.Codigo = Pelicula.Codigo;
            PeliculaToUpdate.Titulo = Pelicula.Titulo;
            PeliculaToUpdate.Año = Pelicula.Año;
            PeliculaToUpdate.Duracion = Pelicula.Duracion;
            

            _peliculaRepository.Update(PeliculaToUpdate);
            return RedirectToPage("./Peliculas");
        }
    }
}
