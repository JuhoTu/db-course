﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface IAccountRepository
    {
        Account Create(Account newAccount);
        List<Account> Read();
        List<Account> Read(long bankId);
        List<Account> Read(long customerId, int i);
        Account Update(Account updateAccount);
        Account Delete(Account deleteAccount);
    }
}
