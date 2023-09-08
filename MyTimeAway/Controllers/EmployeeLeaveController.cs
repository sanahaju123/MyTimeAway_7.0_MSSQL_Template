﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTimeAway.BusinessLayer.Interfaces;
using MyTimeAway.BusinessLayer.ViewModels;
using MyTimeAway.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTimeAway.Controllers
{
    [ApiController]
    public class EmployeeLeaveController : ControllerBase
    {
        private readonly IEmployeeLeaveService _employeeLeaveService;
        public EmployeeLeaveController(IEmployeeLeaveService employeeLeaveService)
        {
            _employeeLeaveService = employeeLeaveService;
        }

        [HttpPost]
        [Route("create-leave")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateLeave([FromBody] EmployeeLeave model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-leave")]
        public async Task<IActionResult> UpdateLeave([FromBody] EmployeeLeaveViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("cancel-leave")]
        public async Task<IActionResult> CancelLeave(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("approve-leave")]
        public async Task<IActionResult> ApproveLeave(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("reject-leave")]
        public async Task<IActionResult> RejectLeave(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete-leave")]
        public async Task<IActionResult> DeleteLeave(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-leave-by-id")]
        public async Task<IActionResult> GetLeaveById(long id)
        {  //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("search-leaves")]
        public async Task<IActionResult> SearchLeaves(string employeeId,string employeeName,int totalDays)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-all-leaves")]
        public async Task<IEnumerable<EmployeeLeave>> GetAllLeaves()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
