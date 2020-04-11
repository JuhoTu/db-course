using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using db_task.Data;
using db_task.Models;
using db_task.Services;

namespace db_task.Repository
{
    class PhoneRepository : IPhoneRepository
    {
        //Inject
        private readonly PersonContext _personContext = new PersonContext();

        public phone Create(phone newphone)
        {
            try
            {
                _personContext.phone.Add(newphone);
                _personContext.SaveChanges();
                Console.WriteLine("Phone saved");
                return newphone;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<phone> Read(long id)
        {
            var phones = _personContext.phone.Where(p => p.personId == id).ToList();
            return phones;
        }

        public phone ReadById(long id)
        {
            var phones = _personContext.phone.FirstOrDefault(p => p.id == id);
            return phones;
        }

        public phone Update(phone updatedNum)
        {
            _personContext.phone.Update(updatedNum);
            _personContext.SaveChanges();
            Console.WriteLine("Phone saved");
            return updatedNum;
        }

        public void Delete(phone dPhone)
        {
            _personContext.phone.Remove(dPhone);
            _personContext.SaveChanges();
        }
    }
}
