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
    public class CrearClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public CrearClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [BindProperty]
        public Cliente Cliente { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _clienteRepository.Insert(Cliente);
            return RedirectToPage("./Clientes");
        }
    }
}
