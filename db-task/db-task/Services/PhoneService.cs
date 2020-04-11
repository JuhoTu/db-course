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

        public phone ReadById(long id)
        {
            var phones = _phoneRepository.ReadById(id);
            return phones;
        }

        public phone Update(long id, phone updatedNum)
        {
            var getPhone = Read(id);
            if (getPhone == null)
            {
                Console.WriteLine("Can't find phone -- update failed.");
                return null;
            }
            var phones = _phoneRepository.Update(updatedNum);
            return updatedNum;
        }

        public void Delete(phone dPhone)
        {
            _phoneRepository.Delete(dPhone);
        }
    }
}
