using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Repository;

namespace BankApp.Services
{
    class TransactionService : ITransactionService
    {
        //Inject
        private readonly ITransactionRepository _transactionRepository = new TransactionRepository();
        public Transaction Create(Transaction newTransaction)
        {
            throw new NotImplementedException();
        }

        public Transaction Read(Transaction readTransaction)
        {
            throw new NotImplementedException();
        }

        public Transaction Update(Transaction updateTransaction)
        {
            throw new NotImplementedException();
        }

        public Transaction Delete(Transaction deleteTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
