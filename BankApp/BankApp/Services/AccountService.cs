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

        public List<Account> Read()
        {
            var accounts = _accountRepository.Read();
            return accounts;
        }

        public List<Account> Read(long bankId)
        {
            var accounts = _accountRepository.Read(bankId);
            return accounts;
        }

        public List<Account> Read(long customerId, int i)
        {
            var accounts = _accountRepository.Read(customerId, i);
            return accounts;
        }

        public Account Update(Account updateAccount)
        {
            var account = _accountRepository.Update(updateAccount);
            return updateAccount;
        }

        public Account Delete(Account deleteAccount)
        {
            _accountRepository.Delete(deleteAccount);
            return deleteAccount;
        }
    }
}
