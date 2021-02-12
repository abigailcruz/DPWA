using Laboratorio1DATA.Interfaces;
using Laboratorio1Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Laboratorio1DATA
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
      
        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
