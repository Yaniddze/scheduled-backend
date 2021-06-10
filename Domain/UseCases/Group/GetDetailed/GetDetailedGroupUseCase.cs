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
            var group = await _context.Groups
                .Include(x => x.GroupSubjects)
                .ThenInclude(x => x.Subject)
                .ThenInclude(x => x.Teacher)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (group is null)
            {
                return Failure("Группа не найдена");
            }

            var result = new
            {
                group.Id,
                Owner = false,
                Tasks = group.GroupSubjects
                    .Where(x => !x.ManualDeleted)
                    .Select(x => new
                    {
                        x.Id,
                        x.StartDate,
                        x.DurationInMinutes,
                        SubjectName = x.Subject.Name,
                        Teacher = x.Subject.Teacher?.Name,
                    })
                    .OrderBy(x => x.StartDate)
                    .GroupBy(x => $"{x.StartDate.Day}-{x.StartDate.Month}-{x.StartDate.Year}")
                    .Select(x => new
                    {
                        Date = x.Key,
                        Subjects = x.Select(z => z)
                    }),
            };

            return SuccessData(result);
        }
    }
}