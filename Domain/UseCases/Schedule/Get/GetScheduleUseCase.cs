using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Schedule.Get
{
    public class GetScheduleUseCase: IUseCase<GetScheduleInput>
    {
        private readonly IAppContext _context;

        public GetScheduleUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(GetScheduleInput request, CancellationToken cancellationToken)
        {
            var lessons = await _context.GroupSubjects
                .Where(x => x.StartDate.Day + "-" + x.StartDate.Month + "-" + x.StartDate.Year == request.Date)
                .Where(x => x.GroupId == request.GroupId)
                .Select(x => new
                {
                    x.Id,
                    x.StartDate,
                    x.DurationInMinutes,
                    SubjectName = x.Subject.Name,
                    Teacher = x.Subject.Teacher.Name,
                })
                .OrderBy(x => x.StartDate)
                .ToListAsync(cancellationToken);
            
            return ActionOutput.SuccessData(lessons);
        }
    }
}