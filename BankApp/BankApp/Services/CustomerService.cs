using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Repository;

namespace BankApp.Services
{
    class CustomerService : ICustomerService
    {
        //Inject
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();
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
