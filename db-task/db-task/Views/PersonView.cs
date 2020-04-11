using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;
using db_task.Services;
using db_task.Views;

namespace db_task
{
    class PersonView : IPersonView
    {
        //Inject
        private readonly IPersonService _personService = new PersonService();

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
