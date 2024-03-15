﻿using HRLeaveManagement.BlazorUI.Models.LeaveTypes;
using HRLeaveManagement.BlazorUI.Services.Base;

namespace HRLeaveManagement.BlazorUI.Contracts
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypeViewModel>> GetLeaveTypes();
        Task<LeaveTypeViewModel> GetLeaveTypeDetails(int id);
        Task<Response<Guid>> CreateLeaveType(LeaveTypeViewModel leaveType);
        Task<Response<Guid>> UpdateLeaveType(int id, LeaveTypeViewModel leaveType);
        Task<Response<Guid>> DeleteLeaveType(int id);
    }
}
