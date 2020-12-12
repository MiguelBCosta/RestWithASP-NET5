using Microsoft.EntityFrameworkCore;
using RestWithASPNET.Model.Base;
using RestWithASPNET.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySQLContext _MySQLContext;
        private DbSet<T> _EntityDataset;
        public GenericRepository(MySQLContext context)
        {
            _MySQLContext = context;
            _EntityDataset = _MySQLContext.Set<T>();
        }

        public T Create(T entity)
        {
            _MySQLContext.Add(entity);
            _MySQLContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            if (!Exists(entity.Id)) return null;
            var result = _EntityDataset.SingleOrDefault(p => p.Id.Equals(entity.Id));
            if (result != null)
            {
                _MySQLContext.Entry(result).CurrentValues.SetValues(entity);
                _MySQLContext.SaveChanges();
            }            
            return result;
        }

        public void Delete(long id)
        {
            var result = _EntityDataset.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                _EntityDataset.Remove(result);
                _MySQLContext.SaveChanges();
            }
        }
        public bool Exists(long id)
        {
            return _EntityDataset.Any(p => p.Id.Equals(id));
        }

        public IEnumerable<T> FindAll()
        {
            return _EntityDataset;
        }

        public T FindById(long id)
        {
           return _EntityDataset.SingleOrDefault(p => p.Id.Equals(id));
        }
      
    }
}
