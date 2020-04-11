using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using db_task.Data;
using db_task.Models;

namespace db_task.Repository
{
    class PersonRepository : IPersonRepository
    {
        //Inject
        private readonly PersonContext _personContext = new PersonContext();

        public person Create(person newPerson)
        {
            try
            {
                _personContext.person.Add(newPerson);
                _personContext.SaveChanges();
                Console.WriteLine("Person saved");
                return newPerson;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<person> Read()
        {
            var persons = _personContext.person.ToList();
            return persons;
        }

        public person Update(person updatePerson)
        {
            throw new NotImplementedException();
        }

        public person Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
