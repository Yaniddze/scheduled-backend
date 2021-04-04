using System;
using System.Collections.Generic;
using System.IO;
using MediatR;

namespace Domain.Services.Parser
{
    public class ExtractSubjectsFromFileInput: IRequest<ExtractResult>
    {
        public ExtractSubjectsFromFileInput(Stream file)
        {
            File = file;
        }

        public Stream File { get; set; }
    }

    public class ExtractResult
    {
        public string TimeStart { get; set; }
        public DateTime Date { get; set; }
        public List<ExtractGroup> Groups { get; set; }
    }

    public class ExtractGroup
    {
        public string Name { get; set; }
        public List<ExtractSubject> Subjects { get; set; }
    }
    
    public class ExtractSubject
    {
        public int Number { get; set; }
        public string SubjectName { get; set; }
        public string Teacher { get; set; }
        public string Cabinet { get; set; }
    }
}