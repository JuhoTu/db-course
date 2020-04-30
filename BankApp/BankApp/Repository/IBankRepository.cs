using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface IBankRepository
    {
        Bank Create(Bank newBank);
        List<Bank> Read();
        Bank Update(Bank updateBank);
        Bank Delete(Bank deleteBank);
    }
}
