using System.Threading.Tasks;
using Domain.Services.Parser;
using Domain.UseCases.Account.Login;
using Domain.UseCases.Account.Register;
using Microsoft.AspNetCore.Mvc;
using Schedule.Implementations;

namespace Schedule.Controllers.Account
{
    [Route("api/v1/account")]
    public class AccountController: Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;
        private readonly ParserService _service;

        public AccountController(IUseCaseDispatcher dispatcher, ParserService service)
        {
            _dispatcher = dispatcher;
            _service = service;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginInput request) =>
            await _dispatcher.DispatchAsync(request);

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterInput request) =>
            await _dispatcher.DispatchAsync(request);

        [HttpGet]
        public async Task<IActionResult> ASdd() 
        {
            await _service.ParseSubjects();

            return Ok();
        }
    }
}