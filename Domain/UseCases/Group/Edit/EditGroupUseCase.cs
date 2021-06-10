using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Group.Edit
{
    public class EditGroupUseCase: IUseCase<EditGroupInput>
    {
        private readonly IAppContext _context;

        public EditGroupUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(EditGroupInput request, CancellationToken cancellationToken)
        {
            var item = await _context.Groups.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            item.Name = request.Name;

            await _context.SaveChangesAsync(cancellationToken);
            
            return ObjectOutput.CreateWithId(request.Id);
        }
    }
}