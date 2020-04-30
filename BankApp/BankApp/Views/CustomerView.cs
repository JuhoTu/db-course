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
        public void Create()
        {
            Console.WriteLine("Input first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Input last name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Input bank id: ");
            long bankId = long.Parse(Console.ReadLine()); // expecting the user to input a correct value
            Customer newCustomer = new Customer() { FirstName = fName, LastName = lName, BankId = bankId };
            _customerService.Create(newCustomer);
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
