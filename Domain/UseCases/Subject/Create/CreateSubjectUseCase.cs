using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Subject.Create
{
    public class CreateSubjectUseCase: IUseCase<CreateSubjectInput>
    {
        private readonly IAppContext _context;

        public CreateSubjectUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(CreateSubjectInput request, CancellationToken cancellationToken)
        {
            var subject = new Entities.Subject
            {
                Name = request.Name,
                TeacherId = request.TeacherId
            };

            _context.Subjects.Add(subject);

            await _context.SaveChangesAsync(cancellationToken);
            
            return ObjectOutput.CreateWithId(subject.Id);
        }
    }
}