using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface ICustomerRepository
    {
        Customer Create(Customer newCustomer);
        List<Customer> Read();
        List<Customer> Read(long bankId);
        Customer Update(Customer updateCustomer);
        Customer Delete(Customer deleteCustomer);
    }
}
