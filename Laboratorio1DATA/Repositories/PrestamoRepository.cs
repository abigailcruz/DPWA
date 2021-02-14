using Laboratorio1DATA.Interfaces;
using Laboratorio1Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1DATA.Repositories
{
    public class PrestamoRepository : Repository<Prestamo>, IPrestamoRepository
    {
        private readonly ApplicationDbContext _db;
        public PrestamoRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
