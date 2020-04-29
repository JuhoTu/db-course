using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface IAccountRepository
    {
        Account Create(Account newAccount);
        Account Read(Account readAccount);
        Account Update(Account updateAccount);
        Account Delete(Account deleteAccount);
    }
}
