using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Teacher.Remove
{
    public class RemoveTeacherUseCase: IUseCase<RemoveTeacherInput>
    {
        private readonly IAppContext _context;

        public RemoveTeacherUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(RemoveTeacherInput request, CancellationToken cancellationToken)
        {
            var teacher = await _context.Teachers
                .FirstOrDefaultAsync(x => x.Id == request.TeacherId, cancellationToken);

            _context.Teachers.Remove(teacher);

            await _context.SaveChangesAsync(cancellationToken);
            
            return ObjectOutput.CreateWithId(teacher.Id);
        }
    }
}