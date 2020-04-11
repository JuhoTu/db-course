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
        private readonly IPhoneRepository _phoneRepository = new PhoneRepository();

        public phone Create(phone newphone)
        {
            var phone =_phoneRepository.Create(newphone);
            return phone;
        }

        public List<phone> Read(long id)
        {
            var phones = _phoneRepository.Read(id);
            return phones;
        }

        public phone Update(long id, phone updatephone)
        {
            var phones = _phoneRepository.Update(id, updatephone);
            return phones;
        }

        public phone Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
