using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.Teacher;
using Domain.UseCases.Teacher.Create;
using Domain.UseCases.Teacher.Update;
using Microsoft.AspNetCore.Mvc;
using Schedule.Abstractions;
using Schedule.Identity;
using Schedule.Implementations;

namespace Schedule.Controllers.Admin
{
    [Route("admin/api/v1/teacher"), AuthorizeByRoles(UserRole.Admin, UserRole.Moderator)]
    public class TeacherAdminController: QueryController<TeacherViewModel, Teacher, TeacherViewModel>
    {
        private readonly IUseCaseDispatcher _dispatcher;
        
        public TeacherAdminController(QueryHandler<TeacherViewModel, Teacher, TeacherViewModel> queryHandler, IUseCaseDispatcher dispatcher) : base(queryHandler)
        {
            _dispatcher = dispatcher;
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTeacherInput request) => await _dispatcher.DispatchAsync(request);
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] CreateTeacherInput request, [FromRoute] int id) => 
            await _dispatcher.DispatchAsync(new UpdateTeacherInput
            {
                Id = id,
                Name = request.Name,
            });
    }
}