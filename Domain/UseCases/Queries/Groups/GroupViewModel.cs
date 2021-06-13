using System;
using System.Linq;
using AutoMapper;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Queries.Groups
{
    public class GroupViewModel: IFilter, IQueryOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SomeTeachers[] Teachers { get; set; }
        public string q { get; set; }
    }

    public class SomeTeachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class GroupViewModelMapper: Profile
    {
        public GroupViewModelMapper()
        {
            CreateMap<Entities.Group, GroupViewModel>()
                .ForMember(x => x.Teachers,
                map => map.MapFrom(
                    dest => dest.GroupSubjects
                        .Select(z => z.Subject)
                        .Select(z => z.Teacher)
                        .GroupBy(z => z != null ? z.Id : 0)
                        .Select(z => new SomeTeachers
                        {
                            Id = z.Key,
                            Name = z.Key == 0 ? "Не указан" : z.First().Name,
                        })
                )
            );;
        }
    }
}