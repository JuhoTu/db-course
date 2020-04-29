using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;

namespace BankApp.Repository
{
    interface ICustomerRepository
    {
        CustomerSection Create(CustomerSection newCustomer);
        CustomerSection Read(CustomerSection readCustomer);
        CustomerSection Update(CustomerSection updateCustomer);
        CustomerSection Delete(CustomerSection deleteCustomer);
    }
}
