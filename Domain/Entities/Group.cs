using System.Collections.Generic;
using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class Group: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IReadOnlyList<User> Members { get; set; }

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