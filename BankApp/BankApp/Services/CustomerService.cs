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

        public List<Customer> Read()
        {
            var customers = _customerRepository.Read();
            return customers;
        }

        public List<Customer> Read(long bankId)
        {
            var customers = _customerRepository.Read(bankId);
            return customers;
        }

        public Customer Update(Customer updateCustomer)
        {
            var customer = _customerRepository.Update(updateCustomer);
            return updateCustomer;
        }

        public Customer Delete(Customer deleteCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
