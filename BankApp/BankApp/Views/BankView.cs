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
            Console.WriteLine("Input bank name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input bank BIC: ");
            string bic = Console.ReadLine();
            Bank newBank = new Bank() {Name = name, BIC = bic};
            _bankService.Create(newBank);
        }

        public void Read()
        {
            var banks = _bankService.Read();
            PrintBanks(banks);
        }

        public void Update()
        {
            Console.WriteLine("Give the bank's id whose name you want to configure: ");
            long id = long.Parse(Console.ReadLine());
            var banks = _bankService.Read();
            var bank = ReturnBankId(banks, id);
            if (bank != null)
            {
                Console.WriteLine("Input a new name to bank: ");
                bank.Name = Console.ReadLine();
                _bankService.Update(bank);
            }
            else
            {
                Console.WriteLine("Could not find a bank with id " + id);
            }
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

        private Bank ReturnBankId(List<Bank> banks, long id)
        {
            foreach (var b in banks)
            {
                if (b.Id == id)
                    return b;
            }

            return null;
        }
    }
}
