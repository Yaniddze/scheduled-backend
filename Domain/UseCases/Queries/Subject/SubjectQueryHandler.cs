using System.Linq;
using AutoMapper;
using Domain.Abstractions.Data;

namespace Domain.UseCases.Queries.Subject
{
    public class SubjectQueryHandler: QueryHandler<SubjectViewModel, Entities.Subject, SubjectViewModel>
    {
        public SubjectQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override IQueryable<Entities.Subject> Filter(IQueryable<Entities.Subject> query, SubjectViewModel filter)
        {
            return query;
        }
    }
}