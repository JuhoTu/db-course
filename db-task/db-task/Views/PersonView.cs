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

        public void Create(person newPerson)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            var persons = _personService.Read();
            PrintPersonData(persons);
        }

        public void Update(person updatePerson)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        private void PrintPersonData(List<person> persons)
        {
            Console.WriteLine("\t\tName\tAge\tPhone");
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.id}\t{p.name}\t{p.age}\t{p.phone}");
            }
        }
    }
}
