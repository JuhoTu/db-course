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
        public Customer Create(Customer newCustomer)
        {
            try
            {
                _bankdbContext.Customer.Add(newCustomer);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Customer added successfully");
                return newCustomer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customer creation failed" + ex.Message);
                return null;
            }
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
