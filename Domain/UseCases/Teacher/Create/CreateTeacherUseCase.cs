using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Teacher.Create
{
    public class CreateTeacherUseCase: IUseCase<CreateTeacherInput>
    {
        private readonly IAppContext _context;

        public CreateTeacherUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(CreateTeacherInput request, CancellationToken cancellationToken)
        {
            var teacher = new Entities.Teacher
            {
                Name = request.Name
            };

            _context.Teachers.Add(teacher);

            await _context.SaveChangesAsync(cancellationToken);
            
            return ObjectOutput.CreateWithId(teacher.Id);
        }
    }
}