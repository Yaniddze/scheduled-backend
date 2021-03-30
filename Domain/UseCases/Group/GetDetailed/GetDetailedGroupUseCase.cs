using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Domain.Abstractions.Outputs.ActionOutput;

namespace Domain.UseCases.Group.GetDetailed
{
    public class GetDetailedGroupUseCase: IUseCase<GetDetailedGroupInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public GetDetailedGroupUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<IOutput> Handle(GetDetailedGroupInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput(), cancellationToken);
            
            var group = await _context.Groups
                .Include(x => x.GroupSubjects)
                .ThenInclude(x => x.Subject)
                .ThenInclude(x => x.Teacher)
                .FirstOrDefaultAsync(x => x.Members.Contains(currentUser) || x.OwnerId == currentUser.Id, cancellationToken);

            if (group is null)
            {
                return Failure("Группа не найдена");
            }

            var result = new
            {
                group.Id,
                Members = group.Members.Select(x => x.UserName),
                Subjects = group.GroupSubjects
                    .OrderByDescending(x => x.StartDate)
                    .Select(x => new
                    {
                        x.Id,
                        x.StartDate,
                        x.DurationInMinutes,
                        SubjectName = x.Subject.Name,
                        Teacher = x.Subject.Teacher.Name,
                    })
                    .GroupBy(x => $"{x.StartDate.Day}-{x.StartDate.Month}-{x.StartDate.Year}"),
            };

            return SuccessData(result);
        }
    }
}