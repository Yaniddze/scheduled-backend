using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Domain.Abstractions.Outputs.ActionOutput;

namespace Domain.UseCases.Group.Join
{
    public class JoinGroupUseCase: IUseCase<JoinGroupInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public JoinGroupUseCase(IMediator mediator, IAppContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        public async Task<IOutput> Handle(JoinGroupInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput(), cancellationToken);

            var group = await _context.Groups.FirstOrDefaultAsync(x => x.Name == request.Name, cancellationToken);

            if (group is null)
            {
                return Failure("Группа не найдена");
            }
            
            group.Members.Add(currentUser);

            await _context.SaveChangesAsync(cancellationToken);
            
            return Success;
        }
    }
}