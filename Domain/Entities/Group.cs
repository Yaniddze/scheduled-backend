using System.Collections.Generic;
using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class Group: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyList<GroupSubject> GroupSubjects { get; set; } = new List<GroupSubject>();

        public Group(string name, User owner = null)
        {
            Name = name;
        }
        
        protected Group() {}
    }
}