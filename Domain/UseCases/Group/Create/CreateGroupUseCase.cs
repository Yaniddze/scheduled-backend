using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Services.Identity;
using MediatR;

namespace Domain.UseCases.Group.Create
{
    public class CreateGroupUseCase: IUseCase<CreateGroupInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public CreateGroupUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<IOutput> Handle(CreateGroupInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput(), cancellationToken);
            
            var group = new Entities.Group(request.Name, currentUser);

            _context.Groups.Add(group);

            await _context.SaveChangesAsync(cancellationToken);
            
            return ActionOutput.SuccessData(new
            {
                group.Id,
            });
        }
    }
}