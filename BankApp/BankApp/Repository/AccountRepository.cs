using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Data;
using BankApp.Models;

namespace BankApp.Repository
{
    class AccountRepository : IAccountRepository
    {
        //Inject
        private readonly BankdbContext _bankdbContext = new BankdbContext();
        public Account Create(Account newAccount)
        {
            throw new NotImplementedException();
        }

        public Account Read(Account readAccount)
        {
            throw new NotImplementedException();
        }

        public Account Update(Account updateAccount)
        {
            throw new NotImplementedException();
        }

        public Account Delete(Account deleteAccount)
        {
            throw new NotImplementedException();
        }
    }
}
