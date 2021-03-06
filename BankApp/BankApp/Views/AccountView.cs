﻿using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Services;

namespace BankApp.Views
{
    class AccountView : IAccountView
    {
        //Inject
        private readonly IAccountService _accountService = new AccountService();
        public void Create(long customerId)
        {
            string IBAN = CreateIBAN();
            Console.WriteLine("Input account name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input bank id: ");
            long bankId = long.Parse(Console.ReadLine()); // expecting the user to input a correct value
            Account newAccount = new Account() { IBAN = IBAN, Name = name, BankId = bankId, CustomerId = customerId, Balance = 0};
            _accountService.Create(newAccount);
        }

        public void Read()
        {
            var accounts = _accountService.Read();
            PrintAccounts(accounts);
        }

        public void Read(long bankId)
        {
            var accounts = _accountService.Read(bankId);
            PrintAccounts(accounts);
        }

        public string Read(long customerId, int i)
        {
            var accounts = _accountService.Read(customerId, i);
            if (i == -1)
            {
                PrintAccounts(accounts);
                return null;
            }

            return accounts[i].IBAN;
        }

        public void Update(string IBAN, decimal amount)
        {
            var accounts = _accountService.Read();
            var updateAccount = ReturnAccountByIBAN(accounts, IBAN);
            if (updateAccount != null)
            {
                updateAccount.Balance += amount;
                _accountService.Update(updateAccount);
            }
            else
            {
                Console.WriteLine("Could not find account with IBAN: " + IBAN);
            }
        }

        public void Delete()
        {
            var accounts = _accountService.Read();
            Console.WriteLine("Input customer's id whose account you want to delete: ");
            long customerId = long.Parse(Console.ReadLine()); // expecting the user to input a correct value
            string IBAN = Read(customerId, 0);
            var deleteAccount = ReturnAccountByIBAN(accounts, IBAN);
            if (deleteAccount != null)
            {
                _accountService.Delete(deleteAccount);
            }
            else
            {
                Console.WriteLine("Could not find account with IBAN: " + IBAN);
            }
        }

        private void PrintAccounts(List<Account> accounts)
        {
            Console.WriteLine("IBAN\t\t\tName\t\tBank\tCustomer\tBalance");
            foreach (var a in accounts)
            {
                Console.Write($"\n{a.IBAN}\t{a.Name}\t\t{a.BankId}\t{a.CustomerId}\t{a.Balance}");
            }
        }

        /// <summary>
        /// Totally correct IBAN creator
        /// </summary>
        /// <returns></returns>
        private string CreateIBAN()
        {
            string IBAN = "FI";
            Random rnd = new Random();
            for (int i = 0; i < 18; i++)
            {
                IBAN += rnd.Next(0, 10);
            }

            return IBAN;
        }

        /// <summary>
        /// Return account by given IBAN
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="IBAN"></param>
        /// <returns></returns>
        private Account ReturnAccountByIBAN(List<Account> accounts, string IBAN)
        {
            foreach (var a in accounts)
            {
                if (a.IBAN == IBAN)
                    return a;
            }

            return null;
        }
    }
}
