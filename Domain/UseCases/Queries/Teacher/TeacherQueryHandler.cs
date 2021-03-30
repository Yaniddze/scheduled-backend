using System.Linq;
using AutoMapper;
using Domain.Abstractions.Data;

namespace Domain.UseCases.Queries.Teacher
{
    public class TeacherQueryHandler: QueryHandler<TeacherViewModel, Entities.Teacher, TeacherViewModel>
    {
        public TeacherQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override IQueryable<Entities.Teacher> Filter(IQueryable<Entities.Teacher> query, TeacherViewModel filter)
        {
            return query;
        }
    }
}