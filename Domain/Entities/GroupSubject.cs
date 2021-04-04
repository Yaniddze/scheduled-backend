using System;
using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class GroupSubject: IEntity
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public int DurationInMinutes { get; set; }     
        
        public string Cabinet { get; set; }

        public Subject Subject { get; set; }
        public int SubjectId { get; set; }

        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}