using MyTimeAway.BusinessLayer.Interfaces;
using MyTimeAway.BusinessLayer.Services.Repository;
using MyTimeAway.BusinessLayer.ViewModels;
using MyTimeAway.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeAway.BusinessLayer.Services
{
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        private readonly IEmployeeLeaveRepository _employeeLeaveRepository;

        public EmployeeLeaveService(IEmployeeLeaveRepository employeeLeaveRepository)
        {
            _employeeLeaveRepository = employeeLeaveRepository;
        }

        public async Task<EmployeeLeave> ApproveLeaveRequest(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> CancelLeaveRequest(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> CreateLeave(EmployeeLeave employeeLeave)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteLeaveById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public List<EmployeeLeave> GetAllLeaves()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> GetLeaveById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> RejectLeaveRequest(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeLeave>> SearchLeaves(string employeeId, string employeeName, int totalDays)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> UpdateLeave(EmployeeLeaveViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
