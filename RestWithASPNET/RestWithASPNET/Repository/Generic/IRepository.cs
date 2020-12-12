using RestWithASPNET.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNET.Repository
{
    public interface IRepository<T> where T:BaseEntity
    {
        T Create(T entity);
        T FindById(long id);
        void Delete(long id);
        T Update(T entity);        
        IEnumerable<T> FindAll();
        bool Exists(long id);
    }
}
