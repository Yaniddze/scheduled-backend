using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Abstractions.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.UseCases.Queries.GroupSubjects
{
    public class GroupSubjectQueryHandler: QueryHandler<GroupSubjectViewModel, GroupSubject, GroupSubjectViewModel>
    {
        public GroupSubjectQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override IQueryable<GroupSubject> Filter(IQueryable<GroupSubject> query, GroupSubjectViewModel filter)
        {
            return query.Where(x => !x.ManualDeleted);
        }

        public override async Task Delete(int id)
        {
            var item = await DbContext.GroupSubjects
                .FirstOrDefaultAsync(x => x.Id == id);

            if (item is null) return;

            item.ManualDeleted = true;

            await DbContext.SaveChangesAsync();
        }
    }
}