using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Services
{
    interface ITransactionService
    {
        Transaction Create(Transaction newTransaction);
        List<Transaction> Read();
        Transaction Update(Transaction updateTransaction);
        Transaction Delete(Transaction deleteTransaction);
    }
}
