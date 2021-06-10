using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;
using Domain.UseCases.Group.Create;
using Domain.UseCases.Group.Edit;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.Groups;
using Microsoft.AspNetCore.Mvc;
using Schedule.Abstractions;
using Schedule.Identity;
using Schedule.Implementations;

namespace Schedule.Controllers.Admin
{
    [Route("admin/api/v1/group"), AuthorizeByRoles(UserRole.Admin)]
    public class GroupAdminController: QueryController<GroupViewModel,Group, GroupViewModel>
    {
        private readonly IUseCaseDispatcher _dispatcher;
        
        public GroupAdminController(
            QueryHandler<GroupViewModel, Group, GroupViewModel> queryHandler, 
            IUseCaseDispatcher dispatcher) 
            : base(queryHandler)
        {
            _dispatcher = dispatcher;
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateGroupInput request) => await _dispatcher.DispatchAsync(request);

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromBody] CreateGroupInput request, [FromRoute] int id) => 
            await _dispatcher.DispatchAsync(new EditGroupInput
            {
                Id = id,
                Name = request.Name,
            });

    }
}