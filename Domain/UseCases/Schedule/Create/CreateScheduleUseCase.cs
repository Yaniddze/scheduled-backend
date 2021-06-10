using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
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

        public CreateScheduleUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(CreateScheduleInput request, CancellationToken cancellationToken)
        {
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
                
                ManualCreated = true,
                
                
            };

            _context.GroupSubjects.Add(groupSubject);

            await _context.SaveChangesAsync(cancellationToken);

            return ObjectOutput.CreateWithId(groupSubject.Id);
        }
    }
}