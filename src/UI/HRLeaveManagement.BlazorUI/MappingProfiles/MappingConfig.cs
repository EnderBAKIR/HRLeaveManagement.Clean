using AutoMapper;
using HRLeaveManagement.BlazorUI.Models.LeaveAllocations;
using HRLeaveManagement.BlazorUI.Models.LeaveRequests;
using HRLeaveManagement.BlazorUI.Models.LeaveTypes;
using HRLeaveManagement.BlazorUI.Services.Base;

namespace HRLeaveManagement.BlazorUI.MappingProfiles
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<LeaveTypeDto, LeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveTypeDetailsDto, LeaveTypeViewModel>().ReverseMap();
            CreateMap<CreateLeaveTypeCommand, LeaveTypeViewModel>().ReverseMap();
            CreateMap<UpdateLeaveTypeCommand, LeaveTypeViewModel>().ReverseMap();

            CreateMap<LeaveRequestListDto, LeaveRequestViewModel>().ReverseMap();
            CreateMap<LeaveRequestDetailsDto, LeaveRequestViewModel>().ReverseMap();
            CreateMap<CreateLeaveRequestCommand, LeaveRequestViewModel>().ReverseMap();
            CreateMap<UpdateLeaveRequestCommand, LeaveRequestViewModel>().ReverseMap();

            CreateMap<LeaveAllocationDto, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<LeaveAllocationDetailsDto, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<CreateLeaveAllocationCommand, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<UpdateLeaveAllocationCommand, LeaveAllocationViewModel>().ReverseMap();
        }
    }
}
