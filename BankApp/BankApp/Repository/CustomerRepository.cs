﻿using System;
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
            throw new NotImplementedException();
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
