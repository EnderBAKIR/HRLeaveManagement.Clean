using HRLeaveManagement.BlazorUI.Contracts;

namespace HRLeaveManagement.BlazorUI.Services.Base
{
    public class LeaveAllocationService : BaseHttpService, ILeaveAllocationService
    {
        public LeaveAllocationService(IClient client) : base(client)
        {
        }
    }

}
