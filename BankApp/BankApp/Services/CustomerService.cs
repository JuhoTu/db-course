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
        public Customer Create(Customer newCustomer)
        {
            var createCustomer = _customerRepository.Create(newCustomer);
            return newCustomer;
        }

        public Customer Read(Customer readCustomer)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer updateCustomer)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(Customer deleteCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
