using HomeInsurance.BusinessLayer.ViewModels;
using HomeInsurance.DataLayer;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeInsurance.BusinessLayer.Services.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly HomeInsuranceDbContext _dbContext;

        public CustomerRepository(HomeInsuranceDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Policy> BuyPolicy(int QuoteId,PolicyModel policyModel)
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
