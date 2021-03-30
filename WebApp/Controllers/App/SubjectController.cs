using System.Threading.Tasks;
using Domain.UseCases.Subject.Get;
using Microsoft.AspNetCore.Mvc;
using Schedule.Implementations;

namespace Schedule.Controllers.App
{
    [Route("api/v1/subject")]
    public class SubjectController: Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;

        public SubjectController(IUseCaseDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => await _dispatcher.DispatchAsync(new GetSubjectsInput());
    }
}