using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Bussines
{
    public interface IBooksBussines
    {
        Book Create(Book Books);
        Book FindById(long id);
        void Delete(long id);
        Book Update(Book Books);
        IEnumerable<Book> FindAll();
    }
}
