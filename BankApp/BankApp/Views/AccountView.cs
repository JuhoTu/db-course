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
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
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
    }
}
