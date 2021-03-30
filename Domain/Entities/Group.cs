using System.Collections.Generic;
using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class Group: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Members { get; set; } = new List<User>();
        public IReadOnlyList<GroupSubject> GroupSubjects { get; set; } = new List<GroupSubject>();

        public int OwnerId { get; set; }
        public User Owner { get; set; }

        public Group(string name, User owner)
        {
            Name = name;

            Owner = owner;
            OwnerId = owner.Id;
        }
        
        protected Group() {}
    }
}