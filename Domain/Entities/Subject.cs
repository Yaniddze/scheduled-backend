using System.Collections.Generic;
using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class Subject: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public IReadOnlyList<GroupSubject> GroupSubjects { get; set; } = new List<GroupSubject>();
    }
}