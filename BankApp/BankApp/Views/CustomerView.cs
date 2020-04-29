using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Services;

namespace BankApp.Views
{
    class CustomerView : ICustomerView
    {
        //Inject
        private readonly ICustomerService _customerService = new CustomerService();
        public void Create()
        {
            throw new NotImplementedException();
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
