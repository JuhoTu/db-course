using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface IBankReposiroty
    {
        BankSection Create(BankSection newBank);
        BankSection Read(BankSection readBank);
        BankSection Update(BankSection updateBank);
        BankSection Delete(BankSection deleteBank);
    }
}
