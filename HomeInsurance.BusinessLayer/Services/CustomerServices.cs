using HomeInsurance.BusinessLayer.Inerfaces;
using HomeInsurance.BusinessLayer.Services.Repository;
using HomeInsurance.BusinessLayer.ViewModels;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeInsurance.BusinessLayer.Services
{
    public class CustomerServices:ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Policy> BuyPolicy(int QuoteId, PolicyModel policyModel)
        {
             //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Quote> RetrieveQuote(int userid)
        {
             //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<User> SignUp(User user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Policy> ViewPolicy(string policyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
