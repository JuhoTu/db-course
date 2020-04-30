using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Views
{
    interface ICustomerView
    {
        long Create();
        void Read();
        void Read(long bankId);
        void Update();
        void Delete();
    }
}
