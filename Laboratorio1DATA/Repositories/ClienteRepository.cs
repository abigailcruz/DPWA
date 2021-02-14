using Laboratorio1DATA.Interfaces;
using Laboratorio1Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1DATA.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public readonly ApplicationDbContext _db;
        public ClienteRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
