using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Entities;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Domain.Abstractions.Outputs.ActionOutput;

namespace Domain.UseCases.Schedule.Create
{
    public class CreateScheduleUseCase: IUseCase<CreateScheduleInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public CreateScheduleUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<IOutput> Handle(CreateScheduleInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput(), cancellationToken);

            var group = await _context.Groups
                .Include(x => x.GroupSubjects)
                .FirstOrDefaultAsync(x => x.Id == request.GroupId, cancellationToken);

            if (group is null)
            {
                return Failure("Группа не найдена");
            }
            
            var subject = await _context.Subjects
                .FirstOrDefaultAsync(x => x.Id == request.SubjectId, cancellationToken);

            if (subject is null)
            {
                return Failure("Предмет не найден");
            }
            
            var groupSubject = new GroupSubject
            {
                DurationInMinutes = request.DurationInMinutes,
                StartDate = request.StartDate,
                
                Group = group,
                GroupId = group.Id,
                
                Subject = subject,
                SubjectId = subject.Id,
            };

            _context.GroupSubjects.Add(groupSubject);

            await _context.SaveChangesAsync(cancellationToken);

            return SuccessData(new
            {
                groupSubject.Id,
            });
        }
    }
}