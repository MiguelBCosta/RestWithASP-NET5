using RestWithASPNET.Model;
using RestWithASPNET.Repository;
using System.Collections.Generic;

namespace RestWithASPNET.Bussines.Implementations
{
    public class PersonBussinesImplementation : IPersonBussines
    {
        private readonly IRepository<Person> _repository;

        public PersonBussinesImplementation(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
