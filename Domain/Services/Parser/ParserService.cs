using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;

namespace Domain.Services.Parser
{
    public class ParserService
    {
        private readonly IMediator _mediator;
        private readonly IAppContext _context;

        public ParserService(IMediator mediator, IAppContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        public async Task ParseSubjects()
        {
            var links = await _mediator.Send(new FileLinksExtractorInput());

            foreach (var link in links)
            {
                var file = await _mediator.Send(new DownloadFileInput(link));

                var extractResult = await _mediator.Send(new ExtractSubjectsFromFileInput(file));

                var startTime = extractResult.TimeStart.Equals("8:30")
                    ? TimeSpan.FromMinutes(8 * 60 + 30)
                    : TimeSpan.FromMinutes(12 * 60 + 30);

                foreach (var group in extractResult.Groups)
                {
                    await _context.GroupSubjects
                        .Where(x => x.StartDate.Day == extractResult.Date.Day)
                        .Where(x => x.StartDate.Year == extractResult.Date.Year)
                        .Where(x => x.StartDate.Month == extractResult.Date.Month)
                        .DeleteAsync();

                    var sorted = group.Subjects
                        .OrderBy(x => x.Number)
                        .ToList();

                    foreach (var subject in sorted)
                    {
                        if (string.IsNullOrEmpty(subject.SubjectName))
                        {
                            RecalculateStartTime(ref startTime, extractResult);
                            continue;
                        }
                        
                        Teacher teacher = null;

                        if (!string.IsNullOrEmpty(subject.Teacher)) 
                        {
                            teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Name == subject.Teacher);

                            if (teacher is null)
                            {
                                teacher = new Teacher
                                {
                                    Name = subject.Teacher
                                };

                                _context.Teachers.Add(teacher);
                                await _context.SaveChangesAsync();
                            }
                        }

                        var foundSubject = await _context.Subjects.FirstOrDefaultAsync(x => x.Name == subject.SubjectName && x.Teacher == teacher);
                        
                        if (foundSubject is null)
                        {
                            foundSubject = new Subject()
                            {
                                Name = subject.SubjectName,
                                Teacher = teacher,
                                TeacherId = teacher?.Id
                            };

                            _context.Subjects.Add(foundSubject);
                            await _context.SaveChangesAsync();
                        }

                        var foundGroup = await _context.Groups.FirstOrDefaultAsync(x => x.Name == group.Name);
                        
                        if (foundGroup is null)
                        {
                            foundGroup = new Group(group.Name);

                            _context.Groups.Add(foundGroup);
                            await _context.SaveChangesAsync();
                        }
                        
                        var groupSubject = new GroupSubject
                        {
                            DurationInMinutes = 95,
                            Group = foundGroup,
                            GroupId = foundGroup.Id,
                            StartDate = extractResult.Date.Add(startTime),
                            Subject = foundSubject,
                            SubjectId = foundSubject.Id,
                        };

                        _context.GroupSubjects.Add(groupSubject);

                        await _context.SaveChangesAsync();

                        RecalculateStartTime(ref startTime, extractResult);
                    }
                }
            }
        }

        private static void RecalculateStartTime(ref TimeSpan startTime, ExtractResult extractResult)
        {
            if (startTime.Minutes == 10 * 60 + 5)
            {
                if (extractResult.Date.DayOfWeek == DayOfWeek.Saturday)
                {
                    startTime += TimeSpan.FromMinutes(110);
                }
                else
                {
                    startTime += TimeSpan.FromMinutes(130);
                }
            }
            else
            {
                startTime += TimeSpan.FromMinutes(95);
            }
        }
    }
}