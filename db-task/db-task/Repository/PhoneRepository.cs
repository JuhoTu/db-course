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

        public phone Update(long id, phone updatephone)
        {
            var phones = _personContext.phone.Where(p => p.id == id).ToList();
            try
            {
                _personContext.phone.Add(updatephone);
                _personContext.SaveChanges();
                Console.WriteLine("Phone saved");
                return updatephone;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public phone Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
