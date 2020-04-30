using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Views
{
    interface ITransactionView
    {
        decimal Create(string IBAN);
        void Read();
        void Read(string IBAN);
        void Update();
        void Delete();
    }
}
