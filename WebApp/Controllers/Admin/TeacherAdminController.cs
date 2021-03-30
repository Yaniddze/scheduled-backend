using Domain.Entities;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.Teacher;
using Microsoft.AspNetCore.Mvc;
using Schedule.Abstractions;

namespace Schedule.Controllers.Admin
{
    [Route("admin/api/v1/teacher")]
    public class TeacherAdminController: QueryController<TeacherViewModel, Teacher, TeacherViewModel>
    {
        public TeacherAdminController(QueryHandler<TeacherViewModel, Teacher, TeacherViewModel> queryHandler) : base(queryHandler)
        {
        }
    }
}