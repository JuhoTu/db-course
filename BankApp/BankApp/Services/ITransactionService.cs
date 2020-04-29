using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Services
{
    interface ITransactionService
    {
        Transaction Create(Transaction newTransaction);
        Transaction Read(Transaction readTransaction);
        Transaction Update(Transaction updateTransaction);
        Transaction Delete(Transaction deleteTransaction);
    }
}
