using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Services
{
    interface IBankService
    {
        Bank Create(Bank newBank);
        List<Bank> Read();
        Bank Update(Bank updateBank);
        Bank Delete(Bank deleteBank);
    }
}
