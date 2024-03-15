using HRLeaveManagement.BlazorUI.Contracts;
using HRLeaveManagement.BlazorUI.Models.LeaveTypes;

namespace HRLeaveManagement.BlazorUI.Services.Base
{
    public class LeaveTypeService : BaseHttpService, ILeaveTypeService
    {
        public LeaveTypeService(IClient client) : base(client)
        {
        }

        public Task<Response<Guid>> CreateLeaveType(LeaveTypeViewModel leaveType)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> DeleteLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveTypeViewModel> GetLeaveTypeDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveTypeViewModel>> GetLeaveTypes()
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> UpdateLeaveType(int id, LeaveTypeViewModel leaveType)
        {
            throw new NotImplementedException();
        }
    }

}
