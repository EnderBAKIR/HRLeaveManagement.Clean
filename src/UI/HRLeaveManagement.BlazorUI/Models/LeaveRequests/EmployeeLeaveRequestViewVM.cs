using HRLeaveManagement.BlazorUI.Models.LeaveAllocations;

namespace HRLeaveManagement.BlazorUI.Models.LeaveRequests
{
    public class EmployeeLeaveRequestViewVM
    {
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}
