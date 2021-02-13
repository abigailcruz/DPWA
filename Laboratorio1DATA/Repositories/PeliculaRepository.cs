using Laboratorio1DATA.Interfaces;
using Laboratorio1Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1DATA.Repositories
{
    public class PeliculaRepository : Repository<Pelicula>, IPeliculaRepository
    {
        private readonly ApplicationDbContext _db;
        public PeliculaRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
