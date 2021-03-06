﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Customer> Read()
        {
            var customers = _bankdbContext.Customer.ToList();
            return customers;
        }

        public List<Customer> Read(long bankId)
        {
            var customers = _bankdbContext.Customer.Where(c => c.BankId == bankId).ToList();
            return customers;
        }

        public Customer Update(Customer updateCustomer)
        {
            try
            {
                _bankdbContext.Customer.Update(updateCustomer);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Customer updated successfully");
                return updateCustomer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customer update failed: " + ex.Message);
                return null;
            }
        }

        public Customer Delete(Customer deleteCustomer)
        {
            try
            {
                _bankdbContext.Customer.Remove(deleteCustomer);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Customer successfully deleted");
                return deleteCustomer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Customer deletion failed: " + e);
                return null;
            }
        }
    }
}
