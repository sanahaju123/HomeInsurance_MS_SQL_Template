using HomeInsurance.BusinessLayer.Inerfaces;
using HomeInsurance.BusinessLayer.ViewModels;
using HomeInsurance.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeInsurance.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IAdminServices _adminService;
        private readonly ICustomerServices _customerService;

        public CustomerController(IAdminServices adminService, ICustomerServices customerService)
        {
            _adminService = adminService;
            _customerService = customerService;
        }

        [HttpPost]
        [Route("customer/signup")]
        public async Task<IActionResult> SignUp([FromBody] User user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("customer/retrieve-quote/{userId}")]
        public async Task<IActionResult> RetrieveQuote(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("customer/view-policy/{policyKey}")]
        public async Task<IActionResult> ViewPolicy(string policyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("customer/BuyPolicy/{quoteId}")]
        public async Task<IActionResult> BuyPolicy(int quoteId,[FromBody] PolicyModel policyModel)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
