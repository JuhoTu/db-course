using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Services
{
    interface ICustomerService
    {
        Customer Create(Customer newCustomer);
        Customer Read(Customer readCustomer);
        Customer Update(Customer updateCustomer);
        Customer Delete(Customer deleteCustomer);
    }
}
