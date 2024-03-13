using FluentValidation;
using HRLeaveManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandValidator : AbstractValidator<CreateLeaveTypeCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeCommandValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("{PropertyName} Is Required")
                .NotNull()
                .MaximumLength(70).WithMessage("{PropertyName} Must be fewer than 70 characters");

            RuleFor(r => r.DefaultDays).GreaterThan(100).WithMessage("{PropertyName} Cannot Exceed 100")
               .LessThan(1).WithMessage("{PropertyName} Cannot Be Less Than 1");

            RuleFor(r => r)
                .MustAsync(LeaveTypeNameUnique)
                .WithMessage("Leave Type Already Exist");
            _leaveTypeRepository = leaveTypeRepository;
        }

        private Task<bool> LeaveTypeNameUnique(CreateLeaveTypeCommand command, CancellationToken token)
        {
            return _leaveTypeRepository.IsLeaveTypeUnique(command.Name);
        }
    }
}
