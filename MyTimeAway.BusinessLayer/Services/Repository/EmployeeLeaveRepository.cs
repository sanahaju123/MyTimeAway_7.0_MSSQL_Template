using Microsoft.EntityFrameworkCore;
using MyTimeAway.BusinessLayer.ViewModels;
using MyTimeAway.DataLayer;
using MyTimeAway.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyTimeAway.BusinessLayer.Services.Repository
{
    public class EmployeeLeaveRepository : IEmployeeLeaveRepository
    {
        private readonly MyTimeAwayDbContext _dbContext;
        public EmployeeLeaveRepository(MyTimeAwayDbContext dbContext)
        {
            _dbContext = dbContext;
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

        public async Task<EmployeeLeave> CreateLeave(EmployeeLeave leaveModel)
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