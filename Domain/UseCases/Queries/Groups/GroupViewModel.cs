using System;
using AutoMapper;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Queries.Groups
{
    public class GroupViewModel: IFilter, IQueryOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string q { get; set; }
    }
    public class GroupViewModelMapper: Profile
    {
        public GroupViewModelMapper()
        {
            CreateMap<Entities.Group, GroupViewModel>();
        }
    }
}