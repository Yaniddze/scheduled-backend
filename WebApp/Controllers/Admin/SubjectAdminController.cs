using System.Threading.Tasks;
using Domain.Entities;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.Subject;
using Domain.UseCases.Subject.Create;
using Domain.UseCases.Subject.Update;
using Microsoft.AspNetCore.Mvc;
using Schedule.Abstractions;
using Schedule.Implementations;

namespace Schedule.Controllers.Admin
{
    public class SubjectAdminController: QueryController<SubjectViewModel, Subject, SubjectViewModel>
    {
        private readonly IUseCaseDispatcher _dispatcher;
        
        public SubjectAdminController(QueryHandler<SubjectViewModel, Subject, SubjectViewModel> queryHandler, IUseCaseDispatcher dispatcher) : base(queryHandler)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSubjectInput request) => await _dispatcher.DispatchAsync(request);
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] CreateSubjectInput request, [FromRoute] int id) => 
            await _dispatcher.DispatchAsync(new UpdateSubjectInput()
            {
                SubjectId = id,
                Name = request.Name,
                TeacherId = request.TeacherId,
            });
    }
}