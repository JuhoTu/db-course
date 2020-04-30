using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Services;

namespace BankApp.Views
{
    class TransactionView : ITransactionView
    {
        //Inject
        private readonly ITransactionService _transactionService = new TransactionService();
        public decimal Create(string IBAN)
        {
            Console.WriteLine("Enter the amount: ");
            decimal amount = int.Parse(Console.ReadLine());
            Transaction newTransaction = new Transaction() {IBAN = IBAN, Amount = amount};
            _transactionService.Create(newTransaction);
            return amount;
        }

        public void Read()
        {
            var transactions = _transactionService.Read();
            PrintTransactions(transactions);
        }

        public void Read(string IBAN)
        {
            var transactions = _transactionService.Read(IBAN);
            PrintTransactions(transactions);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        private void PrintTransactions(List<Transaction> transactions)
        {
            Console.WriteLine("id\tIBAN\t\t\tAmount\tDate");
            foreach (var t in transactions)
            {
                Console.Write($"\n{t.Id}\t{t.IBAN}\t{t.Amount}\t{t.TimeStamp}");
            }
        }
    }
}
