using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.GroupSubjects;
using Domain.UseCases.Schedule.Create;
using Microsoft.AspNetCore.Mvc;
using Schedule.Abstractions;
using Schedule.Identity;
using Schedule.Implementations;

namespace Schedule.Controllers.Admin
{
    [Route("admin/api/v1/groupsubject"), AuthorizeByRoles(UserRole.Admin)]
    public class GroupSubjectAdminController: QueryController<GroupSubjectViewModel, GroupSubject, GroupSubjectViewModel>
    {
        private readonly IUseCaseDispatcher _dispatcher;
        
        public GroupSubjectAdminController(
            QueryHandler<GroupSubjectViewModel, GroupSubject, GroupSubjectViewModel> queryHandler, IUseCaseDispatcher dispatcher) : base(queryHandler)
        {
            _dispatcher = dispatcher;
        }
        
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateScheduleInput request) => await _dispatcher.DispatchAsync(request);
    }
}