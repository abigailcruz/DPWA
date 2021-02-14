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
    public class EliminarClienteModel : PageModel
    {

        private readonly IClienteRepository _clienteRepository;

        public EliminarClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public IActionResult OnGet(int Id)
        {
            Cliente = _clienteRepository.GetById(Id);
            if (Cliente == null)
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

            var ClienteToDelete = _clienteRepository.GetById(Id);
            if (ClienteToDelete == null)

                return NotFound();

            ClienteToDelete.CodigoCliente = Cliente.CodigoCliente;
            ClienteToDelete.NombreCliente = Cliente.NombreCliente;
            ClienteToDelete.ApellidoCliente = Cliente.ApellidoCliente;
            ClienteToDelete.Direccion = Cliente.Direccion;

            _clienteRepository.Delete(ClienteToDelete);
            return RedirectToPage("./Clientes");
        }
    }
}
