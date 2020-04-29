using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Services;

namespace BankApp.Views
{
    class BankView : IBankView
    {
        //Inject
        private readonly IBankService _bankService = new BankService();
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
