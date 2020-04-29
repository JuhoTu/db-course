using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Services;

namespace BankApp.Views
{
    class BankView : IBankView
    {
        //Inject
        private readonly IBankService _bankService = new BankService();
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            var banks = _bankService.Read();
            PrintBanks(banks);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        private void PrintBanks(List<Bank> banks)
        {
            Console.WriteLine("id\tBank\t\tBIC");
            foreach (var b in banks)
            {
                Console.Write($"\n{b.Id}\t{b.Name}\t\t{b.BIC}");
            }
        }
    }
}
