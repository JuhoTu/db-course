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
            var createTransaction = _transactionRepository.Create(newTransaction);
            return newTransaction;
        }

        public List<Transaction> Read()
        {
            var transactions = _transactionRepository.Read();
            return transactions;
        }

        public List<Transaction> Read(string IBAN)
        {
            var transactions = _transactionRepository.Read(IBAN);
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
