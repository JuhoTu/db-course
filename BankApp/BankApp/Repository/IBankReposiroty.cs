using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface IBankReposiroty
    {
        Bank Create(Bank newBank);
        Bank Read(Bank readBank);
        Bank Update(Bank updateBank);
        Bank Delete(Bank deleteBank);
    }
}
