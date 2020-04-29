using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Data;
using BankApp.Models;

namespace BankApp.Repository
{
    class TransactionRepository : ITransactionRepository
    {
        //Inject
        private readonly BankdbContext _bankdbContext = new BankdbContext();
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
