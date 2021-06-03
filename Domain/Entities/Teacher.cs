using System.Collections.Generic;
using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class Teacher: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParsedName { get; set; }

        public IReadOnlyList<Subject> Subjects { get; set; } = new List<Subject>();
    }
}