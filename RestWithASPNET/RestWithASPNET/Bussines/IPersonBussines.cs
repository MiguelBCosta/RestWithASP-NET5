using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Bussines
{
    public interface IPersonBussines
    {
        Person Create(Person person);
        Person FindById(long id);
        void Delete(long id);
        Person Update(Person person);        
        IEnumerable<Person> FindAll();        
    }
}
