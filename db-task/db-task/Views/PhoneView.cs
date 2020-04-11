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
        private readonly IPhoneService _phoneService = new PhoneService();

        public void Create(int id)
        {
            Console.WriteLine("Input phone number: ");
            phone newPhone = new phone() {number = Console.ReadLine(), type = "home", personId = id};
            _phoneService.Create(newPhone);
        }

        public void Read(long id)
        {
            var phones = _phoneService.Read(id);
            foreach (var phone in phones)
            {
                Console.Write("\t" + phone.number);
            }
        }

        public void Update()
        {
            Console.WriteLine("Give the phone's id whose number you want to configure: ");
            long id = long.Parse(Console.ReadLine());
            var phoneData = _phoneService.ReadById(id);
            phoneData.number = Console.ReadLine();
            _phoneService.Update(id, phoneData);
        }

        public void Delete(long id)
        {
            var phones = _phoneService.Read(id);
            foreach (var phone in phones)
            {
                _phoneService.Delete(phone);
            }
        }
    }
}
