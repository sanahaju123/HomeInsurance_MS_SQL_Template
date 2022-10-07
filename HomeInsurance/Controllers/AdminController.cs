using HomeInsurance.BusinessLayer.Inerfaces;
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
    public class AdminController : ControllerBase
    {
        private readonly IAdminServices _adminService;
        private readonly ICustomerServices _customerService;

        public AdminController(IAdminServices adminService, ICustomerServices customerService)
        {
            _adminService = adminService;
            _customerService = customerService;
        }

        [HttpPost]
        [Route("admin/signup")]
        public async Task<IActionResult> SignUp([FromBody] User user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("admin/add-quote")]
        public async Task<IActionResult> AddQuote([FromBody] Quote quote)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("admin/view-policy/{policyKey}")]
        public async Task<IActionResult> ViewPolicy(string policyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("admin/renew-policy/{policyKey}")]
        public async Task<IActionResult> RenewPolicy(string policyKey)
        {
           //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("admin/cancel-policy/{policyKey}")]
        public async Task<IActionResult> CancelPolicy(string policyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("admin/retrieve-quote/{userId}")]
        public async Task<IActionResult> RetrieveQuote(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

    }
}
