using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Subject.Update
{
    public class UpdateSubjectUseCase: IUseCase<UpdateSubjectInput>
    {
        private readonly IAppContext _context;

        public UpdateSubjectUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(UpdateSubjectInput request, CancellationToken cancellationToken)
        {
            var subject =
                await _context.Subjects.FirstOrDefaultAsync(x => x.Id == request.SubjectId, cancellationToken);

            if (subject is null)
            {
                return ObjectOutput.CreateWithId(1);
            }

            subject.Name = request.Name;
            subject.TeacherId = request.TeacherId;

            await _context.SaveChangesAsync(cancellationToken);
            
            return ObjectOutput.CreateWithId(subject.Id);
        }
    }
}