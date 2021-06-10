using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Domain.Abstractions.Outputs.ActionOutput;

namespace Domain.UseCases.Group.Create
{
    public class CreateGroupUseCase: IUseCase<CreateGroupInput>
    {
        private readonly IAppContext _context;
        private readonly IUnitOfWorkCreator _unitOfWork;

        public CreateGroupUseCase(IAppContext context, IUnitOfWorkCreator unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public async Task<IOutput> Handle(CreateGroupInput request, CancellationToken cancellationToken)
        {
            using var unit = _unitOfWork.CreateUnitOfWork();

            var exist = await _context.Groups.AnyAsync(x => x.Name == request.Name, cancellationToken);

            if (exist)
            {
                return Failure("Такая группа уже существует");
            }
            
            var group = new Entities.Group(request.Name);

            _context.Groups.Add(group);

            await _context.SaveChangesAsync(cancellationToken);

            await unit.Apply();
            
            return ObjectOutput.CreateWithId(group.Id);
        }
    }
}