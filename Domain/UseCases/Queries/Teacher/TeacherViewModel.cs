using System.Linq;
using AutoMapper;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Queries.Teacher
{
    public class TeacherViewModel: IFilter, IQueryOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SomeGroups[] Groups { get; set; }
    }

    public class SomeGroups
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TeacherViewModelProfiler : Profile
    {
        public TeacherViewModelProfiler()
        {
            CreateMap<Entities.Teacher, TeacherViewModel>()
                .ForMember(x => x.Groups,
                    map => map.MapFrom(
                        dest => dest.Subjects
                            .SelectMany(z => z.GroupSubjects)
                            .Select(z => z.Group)
                            .GroupBy(z => z.Id)
                            .Select(z => new SomeGroups
                            {
                                Id = z.Key,
                                Name = z.First().Name,
                            })
                        )
                    );
        }
    }
}