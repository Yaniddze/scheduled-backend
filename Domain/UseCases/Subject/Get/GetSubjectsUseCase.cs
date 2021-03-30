using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Subject.Get
{
    public class GetSubjectsUseCase: IUseCase<GetSubjectsInput>
    {
        private readonly IAppContext _context;

        public GetSubjectsUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(GetSubjectsInput request, CancellationToken cancellationToken)
        {
            var subjects = await _context.Subjects
                .Select(x => new
                {
                    x.Id,
                    x.Name
                })
                .ToListAsync(cancellationToken);
            
            return ActionOutput.SuccessData(subjects);
        }
    }
}