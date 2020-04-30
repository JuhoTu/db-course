using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Services;

namespace BankApp.Views
{
    class CustomerView : ICustomerView
    {
        //Inject
        private readonly ICustomerService _customerService = new CustomerService();
        public long Create()
        {
            Console.WriteLine("Input first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Input last name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Input bank id: ");
            long bankId = long.Parse(Console.ReadLine()); // expecting the user to input a correct value
            Customer newCustomer = new Customer() { FirstName = fName, LastName = lName, BankId = bankId };
            _customerService.Create(newCustomer);
            return newCustomer.Id;
        }

        public void Read()
        {
            var customers = _customerService.Read();
            PrintCustomers(customers);
        }

        public void Read(long bankId)
        {
            var customers = _customerService.Read(bankId);
            PrintCustomers(customers);
        }

        public void Update()
        {
            var customers = _customerService.Read();
            Console.WriteLine("Input customer id: ");
            long customerId = long.Parse(Console.ReadLine()); // expecting the user to input a correct value
            var updateCustomer = ReturnCustomerById(customers, customerId);
            if (updateCustomer != null)
            {
                Console.WriteLine("Change last name to input: ");
                updateCustomer.LastName = Console.ReadLine();
                _customerService.Update(updateCustomer);
            }
            else
            {
                Console.WriteLine("Could not find a customer with customerId: " + customerId);
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        private void PrintCustomers(List<Customer> customers)
        {
            Console.WriteLine("id\tName\t\tBank");
            foreach (var c in customers)
            {
                Console.Write($"\n{c.Id}\t{c.FirstName} {c.LastName}\t{c.Id}");
            }
        }

        /// <summary>
        /// Returns customer by customerId
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="IBAN"></param>
        /// <returns></returns>
        private Customer ReturnCustomerById(List<Customer> customers, long customerId)
        {
            foreach (var c in customers)
            {
                if (c.Id == customerId)
                    return c;
            }

            return null;
        }
    }
}
