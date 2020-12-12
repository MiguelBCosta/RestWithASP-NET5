using RestWithASPNET.Model;
using RestWithASPNET.Repository;
using System.Collections.Generic;

namespace RestWithASPNET.Bussines.Implementations
{
    public class BooksBussinesImplementation:IBooksBussines
    {
        private readonly IRepository<Book> _repository;

        public BooksBussinesImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Book Create(Book Books)
        {
            return _repository.Create(Books);
        }

        public Book Update(Book Books)
        {
            return _repository.Update(Books);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
