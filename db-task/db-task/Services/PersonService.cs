using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;
using db_task.Repository;

namespace db_task.Services
{
    class PersonService : IPersonService
    {
        //Inject
        private readonly IPersonRepository _personRepository = new PersonRepository();

        public person Create(person newPerson)
        {
            var createPerson = _personRepository.Create(newPerson);
            return createPerson;
        }

        public List<person> Read()
        {
            var persons = _personRepository.Read();
            return persons;
        }

        public person ReadById(long id)
        {
            var person = _personRepository.ReadById(id);
            return person;
        }

        public person Update(person updatePerson)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            var getPerson = ReadById(id);
            if (getPerson == null)
                Console.WriteLine("Person has already been removed or not created at all");
            else
            {
                _personRepository.Delete(getPerson);
                Console.WriteLine($"Person {getPerson.name} has been deleted");
            }
        }
    }
}
