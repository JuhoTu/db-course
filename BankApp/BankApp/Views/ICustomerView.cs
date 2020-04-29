using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Views
{
    interface ICustomerView
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
