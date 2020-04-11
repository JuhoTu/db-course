using System;
using System.Collections.Generic;
using System.Text;
using db_task.Data;
using db_task.Models;

namespace db_task.Repository
{
    class PhoneRepository : IPhoneRepository
    {
        //Inject
        private readonly PersonContext _personContext = new PersonContext();

        public phone Create(phone newphone)
        {
            throw new NotImplementedException();
        }

        public List<phone> Read()
        {
            throw new NotImplementedException();
        }

        public phone Update(phone updatephone)
        {
            throw new NotImplementedException();
        }

        public phone Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
