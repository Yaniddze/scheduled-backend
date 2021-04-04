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

namespace Domain.UseCases.Group.Get
{
    public class GetGroupsUseCase: IUseCase<GetGroupsInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public GetGroupsUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<IOutput> Handle(GetGroupsInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput(), cancellationToken);

            var groups = await _context.Groups
                .Where(x => x.Members.Contains(currentUser))
                .Select(x => new
                {
                    x.Id,
                    x.Name
                })
                .ToListAsync(cancellationToken);
            
            return SuccessData(groups);
        }
    }
}