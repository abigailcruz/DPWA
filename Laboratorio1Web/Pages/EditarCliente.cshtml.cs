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
    public class EditarClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        public EditarClienteModel(IClienteRepository clienteRepository)
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

            var ClienteToUpdate = _clienteRepository.GetById(Id);
            if (ClienteToUpdate == null)

                return NotFound();

            ClienteToUpdate.CodigoCliente = Cliente.CodigoCliente;
            ClienteToUpdate.NombreCliente = Cliente.NombreCliente;
            ClienteToUpdate.ApellidoCliente = Cliente.ApellidoCliente;
            ClienteToUpdate.Direccion = Cliente.Direccion;

            _clienteRepository.Update(ClienteToUpdate);
            return RedirectToPage("./Clientes");
        }
    }
}
