using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Domain.Abstractions.Outputs.ActionOutput;

namespace Domain.UseCases.Schedule.Delete
{
    public class DeleteScheduleUseCase: IUseCase<DeleteScheduleInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public DeleteScheduleUseCase(IMediator mediator, IAppContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        public async Task<IOutput> Handle(DeleteScheduleInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput(), cancellationToken);

            var group = await _context.GroupSubjects
                .FirstOrDefaultAsync(x => x.Id == request.ScheduledId && x.Group.OwnerId == currentUser.Id, cancellationToken);

            if (group is null)
            {
                return Failure("Группа не найдена");
            }

            _context.GroupSubjects.Remove(group);
            
            return Success;
        }
    }
}