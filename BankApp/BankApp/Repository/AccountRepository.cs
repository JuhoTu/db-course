using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                _bankdbContext.Account.Add(newAccount);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Account added successfully");
                return newAccount;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Account creation failed" + ex.Message);
                return null;
            }
        }

        public List<Account> Read()
        {
            var accounts = _bankdbContext.Account.ToList();
            return accounts;
        }

        public List<Account> Read(long bankId)
        {
            var accounts = _bankdbContext.Account.Where(a => a.BankId == bankId).ToList();
            return accounts;
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
