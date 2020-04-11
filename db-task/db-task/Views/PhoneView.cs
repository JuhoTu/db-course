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

        public void Create(phone newphone)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update(phone updatephone)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
