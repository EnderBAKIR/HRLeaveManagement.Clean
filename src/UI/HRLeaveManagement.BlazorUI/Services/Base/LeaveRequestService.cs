using HRLeaveManagement.BlazorUI.Contracts;

namespace HRLeaveManagement.BlazorUI.Services.Base
{
    public class LeaveRequestService : BaseHttpService, ILeaveRequestService
    {
        public LeaveRequestService(IClient client) : base(client)
        {
        }
    }

}
