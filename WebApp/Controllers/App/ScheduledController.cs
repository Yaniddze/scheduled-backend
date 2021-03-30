using System.Threading.Tasks;
using Domain.Enums;
using Domain.UseCases.Schedule.Create;
using Domain.UseCases.Schedule.Delete;
using Microsoft.AspNetCore.Mvc;
using Schedule.Identity;
using Schedule.Implementations;

namespace Schedule.Controllers.App
{
    [Route("api/v1/scheduled"), AuthorizeByRoles(UserRole.Participant)]
    public class ScheduledController: Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;

        public ScheduledController(IUseCaseDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
        
        [HttpPut]
        public async Task<IActionResult> Create([FromBody] CreateScheduleInput request) => 
            await _dispatcher.DispatchAsync(request);
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove([FromRoute] int id) => 
            await _dispatcher.DispatchAsync(new DeleteScheduleInput
            {
                ScheduledId = id
            });
    }
}