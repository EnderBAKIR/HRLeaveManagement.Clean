using HRLeaveManagement.BlazorUI.Contracts;

namespace HRLeaveManagement.BlazorUI.Services.Base
{
    public class LeaveTypeService : BaseHttpService, ILeaveTypeService
    {
        public LeaveTypeService(IClient client) : base(client)
        {
        }
    }

}
