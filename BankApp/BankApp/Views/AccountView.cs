using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Services;

namespace BankApp.Views
{
    class AccountView : IAccountView
    {
        //Inject
        private readonly IAccountService _accountService = new AccountService();
        public void Create()
        {
            Console.WriteLine(CreateIBAN());
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
