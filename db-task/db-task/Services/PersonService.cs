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
            throw new NotImplementedException();
        }

        public List<person> Read()
        {
            throw new NotImplementedException();
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
