using AutoMapper;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Queries.Teacher
{
    public class TeacherViewModel: IFilter, IQueryOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TeacherViewModelProfiler : Profile
    {
        public TeacherViewModelProfiler()
        {
            CreateMap<Entities.Teacher, TeacherViewModel>();
        }
    }
}