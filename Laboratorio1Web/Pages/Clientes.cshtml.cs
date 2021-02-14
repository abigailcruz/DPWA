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
    public class ClientesModel : PageModel
    {
       
        
         private readonly IClienteRepository _clienteRepository;
         public ClientesModel(IClienteRepository clienteRepository)
         {
                _clienteRepository = clienteRepository;
         }

         [BindProperty]
         public IEnumerable<Cliente> Clientes { get; set; }
         public IActionResult OnGet()
         {
                Clientes = _clienteRepository.List();
                return Page();
         }
        
    }
}
