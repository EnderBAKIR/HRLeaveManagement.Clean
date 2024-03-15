namespace HRLeaveManagement.BlazorUI.Models.LeaveAllocations
{
    public class ViewLeaveAllocationsViewModel
    {
        public string EmployeeId { get; set; }
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
    }
}
