using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Views
{
    interface IAccountView
    {
        void Create(long customerId);
        void Read();
        void Read(long bankId);
        void Update();
        void Delete();
    }
}
