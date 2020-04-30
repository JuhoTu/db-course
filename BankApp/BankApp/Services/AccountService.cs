﻿using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Repository;

namespace BankApp.Services
{
    class AccountService : IAccountService
    {
        //Inject
        private readonly IAccountRepository _accountRepository = new AccountRepository();
        public Account Create(Account newAccount)
        {
            var createAccount = _accountRepository.Create(newAccount);
            return createAccount;
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
