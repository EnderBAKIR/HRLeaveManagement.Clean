using AutoMapper;
using HRLeaveManagement.Application.Contracts.Logging;
using HRLeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IAppLogger<GetLeaveTypesQueryHandler> _logger;

        public GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository, IAppLogger<GetLeaveTypesQueryHandler> logger)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
            _logger = logger;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {

            var leayeTypes = await _leaveTypeRepository.GetAllAsync();

            var data = _mapper.Map<List<LeaveTypeDto>>(leayeTypes);

            _logger.LogInformation("Leave Type were retrieved successfully");

            return data;

            
        }
    }
}
