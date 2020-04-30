using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Services
{
    interface IAccountService
    {
        Account Create(Account newAccount);
        List<Account> Read();
        List<Account> Read(long bankId);
        Account Update(Account updateAccount);
        Account Delete(Account deleteAccount);
    }
}
