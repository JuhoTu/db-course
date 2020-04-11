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
            var userInput = long.Parse(Console.ReadLine());
            var phoneData = _phoneService.Read(userInput);
            phoneData[0].number = Console.ReadLine();
            _phoneService.Update(userInput, phoneData[0]);
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
