using System;
using System.Collections.Generic;
using System.Text;
using TesteMundivox.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TesteMundivox.Data;

namespace TesteMundivox.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DatabaseContext _db;
        public Repository(DatabaseContext db)
        {
            _db = db;
        }

        public void Add(T obj)
        {
            _db.Set<T>().Add(obj);
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Remove(T obj)
        {
            _db.Set<T>().Remove(obj);
        }

        public void Update(T obj)
        {
            _db.Set<T>().Update(obj);
        }
    }
}
