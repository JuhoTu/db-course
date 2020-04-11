using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;
using db_task.Services;

namespace db_task.Views
{
    class PhoneView : IPhoneView
    {
        //Inject
        private readonly IPhoneService _personService = new PhoneService();

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
