using System;
using AutoMapper;
using Domain.Abstractions.Queries;
using Domain.Entities;

namespace Domain.UseCases.Queries.GroupSubjects
{
    public class GroupSubjectViewModel: IFilter, IQueryOutput
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public int DurationInMinutes { get; set; }

        public int SubjectId { get; set; }

        public int GroupId { get; set; }
    }
    public class GroupSubjectViewModelMapper: Profile
    {
        public GroupSubjectViewModelMapper()
        {
            CreateMap<GroupSubject, GroupSubjectViewModel>();
        }
    }
}