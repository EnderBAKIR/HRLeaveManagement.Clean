using AutoMapper;
using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.MappingProfiles
{
    internal class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
                CreateMap<LeaveTypeDto , LeaveType>().ReverseMap();
        }
    }
}
