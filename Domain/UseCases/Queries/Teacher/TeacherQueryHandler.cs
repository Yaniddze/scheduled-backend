using System.Linq;
using AutoMapper;
using Domain.Abstractions.Data;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Queries.Teacher
{
    public class TeacherQueryHandler: QueryHandler<TeacherViewModel, Entities.Teacher, TeacherViewModel>
    {
        public TeacherQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override IQueryable<Entities.Teacher> GetQuery()
        {
            return base.GetQuery()
                .Include(x => x.Subjects)
                .ThenInclude(x => x.GroupSubjects)
                .ThenInclude(x => x.Group);
        }

        protected override IQueryable<Entities.Teacher> Filter(IQueryable<Entities.Teacher> query, TeacherViewModel filter)
        {
            if (!string.IsNullOrEmpty(filter.Name))
            {
                return query.Where(x => x.Name.ToLower().Contains(filter.Name.ToLower()));
            }
            
            return query;
        }
    }
}