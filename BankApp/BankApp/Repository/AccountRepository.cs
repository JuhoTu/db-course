﻿using System;
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

        public List<Account> Read(long customerId, int i)
        {
            var accounts = _bankdbContext.Account.Where(a => a.CustomerId == customerId).ToList();
            return accounts;
        }

        public Account Update(Account updateAccount)
        {
            try
            {
                _bankdbContext.Account.Update(updateAccount);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Account updated successfully");
                return updateAccount;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Account update failed: " + ex.Message);
                return null;
            }
        }

        public Account Delete(Account deleteAccount)
        {
            try
            {
                _bankdbContext.Account.Remove(deleteAccount);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Account successfully deleted");
                return deleteAccount;
            }
            catch (Exception e)
            {
                Console.WriteLine("Account deletion failed: " + e);
                return null;
            }
        }
    }
}
