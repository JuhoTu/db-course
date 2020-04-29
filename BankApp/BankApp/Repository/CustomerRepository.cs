using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Data;
using BankApp.Models;

namespace BankApp.Repository
{
    class CustomerRepository : ICustomerRepository
    {
        //Inject
        private readonly BankdbContext _bankdbContext = new BankdbContext();
        public CustomerSection Create(CustomerSection newCustomer)
        {
            throw new NotImplementedException();
        }

        public CustomerSection Read(CustomerSection readCustomer)
        {
            throw new NotImplementedException();
        }

        public CustomerSection Update(CustomerSection updateCustomer)
        {
            throw new NotImplementedException();
        }

        public CustomerSection Delete(CustomerSection deleteCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
