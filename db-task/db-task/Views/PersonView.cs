﻿using System;
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
        //Inject
        private readonly IPhoneView _phoneView = new PhoneView();

        public void Create()
        {
            person newPerson = new person() {name = "Mikki Hiiri", age = 123};
            _personService.Create(newPerson);
            _phoneView.Create(newPerson.id);
        }

        public void Read()
        {
            var persons = _personService.Read();
            PrintPersonData(persons);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            Console.WriteLine("Give the person's id you want to remove: ");
            var deletePersonId = int.Parse(Console.ReadLine());
            var getPerson = _personService.ReadById(deletePersonId);
            if (getPerson == null)
                Console.WriteLine("Could not find with given id");
            else
            {
                _phoneView.Delete(deletePersonId);
                _personService.Delete(deletePersonId);
                Console.WriteLine(getPerson.name + "is now deleted");
            }
        }

        private void PrintPersonData(List<person> persons)
        {
            Console.WriteLine("\tName\t\t\tAge\tPhones");
            foreach (var p in persons)
            {
                Console.Write($"\n{p.id}\t{p.name}\t\t{p.age}");
                _phoneView.Read(p.id);
            }
        }
    }
}
