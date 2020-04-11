using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;
using db_task.Repository;

namespace db_task.Services
{
    class PhoneService : IPhoneService
    {
        //Inject
        private readonly IPhoneRepository _personRepository = new PhoneRepository();

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
