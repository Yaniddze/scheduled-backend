using System.Linq;
using AutoMapper;
using Domain.Abstractions.Data;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Queries.Groups
{
    public class GroupQueryHandler: QueryHandler<GroupViewModel, Entities.Group, GroupViewModel>
    {
        public GroupQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override IQueryable<Entities.Group> GetQuery()
        {
            return base.GetQuery()
                .Include(x => x.GroupSubjects)
                .ThenInclude(x => x.Subject)
                .ThenInclude(x => x.Teacher);
        }

        protected override IQueryable<Entities.Group> Filter(IQueryable<Entities.Group> query, GroupViewModel filter)
        {
            if (!string.IsNullOrEmpty(filter.q))
            {
                return query.Where(x => x.Name.ToLower().Contains(filter.q.ToLower()));
            }
            return query;
        }
    }
}