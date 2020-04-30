using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Transaction> Read()
        {
            var transactions = _bankdbContext.Transaction.ToList();
            return transactions;
        }

        public List<Transaction> Read(string IBAN)
        {
            var transactions = _bankdbContext.Transaction.Where(t => t.IBAN == IBAN).ToList();
            return transactions;
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
