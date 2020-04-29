using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface IBankRepository
    {
        BankSection Create(BankSection newBank);
        List<Bank> Read();
        BankSection Update(BankSection updateBank);
        BankSection Delete(BankSection deleteBank);
    }
}
