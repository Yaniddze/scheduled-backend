using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Microsoft.EntityFrameworkCore;
using static Domain.Abstractions.Queries.ObjectOutput;

namespace Domain.UseCases.Teacher.Update
{
    public class UpdateTeacherUseCase: IUseCase<UpdateTeacherInput>
    {
        private readonly IAppContext _context;

        public UpdateTeacherUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(UpdateTeacherInput request, CancellationToken cancellationToken)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (teacher is null)
            {
                return CreateWithId(1);
            }

            teacher.Name = request.Name;

            await _context.SaveChangesAsync(cancellationToken);
            
            return CreateWithId(teacher.Id);
        }
    }
}