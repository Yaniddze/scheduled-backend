using Domain.Abstractions.Queries;

namespace Domain.UseCases.Queries.Subject
{
    public class SubjectViewModel: IFilter, IQueryOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
    }
}