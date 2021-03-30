using System.Threading.Tasks;
using Domain.Enums;
using Domain.UseCases.Group.Create;
using Domain.UseCases.Group.Get;
using Microsoft.AspNetCore.Mvc;
using Schedule.Identity;
using Schedule.Implementations;

namespace Schedule.Controllers.App
{
    [Route("api/v1/group"), AuthorizeByRoles(UserRole.Participant)]
    public class GroupController: Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;

        public GroupController(IUseCaseDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => await _dispatcher.DispatchAsync(new GetGroupsInput());
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateGroupInput request) => 
            await _dispatcher.DispatchAsync(request);
        
        
    }
}