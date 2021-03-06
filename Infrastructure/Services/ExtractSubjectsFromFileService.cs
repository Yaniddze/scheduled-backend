using System.Threading;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;  
using DocumentFormat.OpenXml.Wordprocessing;  
using MediatR;
using Domain.Services.Parser;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;

namespace Infrastructure.Services 
{
    public class ExtractSubjectsFromFileService : IRequestHandler<ExtractSubjectsFromFileInput, ExtractResult>
    {

        public async Task<ExtractResult> Handle(ExtractSubjectsFromFileInput request, CancellationToken cancellationToken)
        {
            using var document = WordprocessingDocument.Open(request.File, false);

            var header = document.MainDocumentPart.Document.Body.InnerText.Split("День №")[0];

            var table = document.MainDocumentPart.Document.Body.Elements<Table>().First();

            var groupRegex = new Regex(@"^[А-Я].\-(\d..|\d...)(\/(б|к))?$");
            var teacherRegex = new Regex(@"[А-Я].{0,12} [А-Я]\.[А-Я]\.( |)(\d.{2}|\s?)");

            var count = table.Elements<TableRow>().Count();

            var groupTables = new List<List<TableRow>>();
            var groupItem = new List<TableRow>();
            
            // Группирую таблицы по надписи "День" слева в заголовке таблицы 
            for (var i = 0; i < count; i++)
            {
                var item = table.Elements<TableRow>().ElementAt(i);

                if (item.Elements<TableCell>().ElementAt(0).InnerText == "День")
                {
                    AddGroupToTables(groupTables, groupItem);

                    groupItem = new List<TableRow>
                    {
                        item
                    };
                    continue;
                }
                groupItem.Add(item);
            }
            AddGroupToTables(groupTables, groupItem);

            var result = new ExtractResult();
            var group = new ExtractGroup();

            groupTables.ForEach(rows => 
            {
                var rowsCount = rows.Count;
                var firstRow = rows.First();
                var cellCount = firstRow.Elements<TableCell>().Count(); 

                // сдвиг для колонок День и № предмета
                for (var i = 2; i < cellCount; i++)
                {
                    for (var j = 0; j < rowsCount; j++)
                    {
                        var row = rows[j];
                        var cell = row.Elements<TableCell>().ElementAt(i);

                        var text = cell.InnerText;

                        if (string.IsNullOrEmpty(text)) continue;

                        //группа
                        if (groupRegex.IsMatch(text))
                        {
                            AddGroupToResult(result, group);
                            group = new ExtractGroup()
                            {
                                Name = text
                            };
                            continue;
                        }

                        // предмет
                        var number = row.Elements<TableCell>().ElementAt(1).InnerText;
                        var teacherMatches = teacherRegex.Matches(text).Select(x => x.Value);
                        var excludeTeachersText = teacherRegex.Replace(text, "");

                        var parsedNumber = 0;

                        if (!int.TryParse(number, out parsedNumber)) 
                        {
                            parsedNumber = (group.Subjects.LastOrDefault()?.Number ?? 0) + 1;
                        }

                        group.Subjects.Add(new ExtractSubject
                        {
                            Number = parsedNumber,
                            Teacher = string.Join("\n", teacherMatches),
                            SubjectName = excludeTeachersText,
                        });
                    }
                }
                AddGroupToResult(result, group);
            });

            result.TimeStart = header.Contains("12:30") ? "12:30" : "8:30";
            var now = DateTime.Now;

            var newHeader = header.Replace(result.TimeStart, "");

            var numberRegex = new Regex(@"\d.");
            var number = numberRegex.Matches(newHeader).LastOrDefault()?.Value ?? "";

            int.TryParse(number, out var parsed);

            if (now.Day == parsed) 
            {
                result.Date = new DateTime(now.Year, now.Month, now.Day);
            }
            var yesterday = (now - TimeSpan.FromDays(1));
            if (yesterday.Day == parsed) 
            {
                result.Date = new DateTime(yesterday.Year, yesterday.Month, yesterday.Day);
            }
            var tomorrow = (now + TimeSpan.FromDays(1));
            if (tomorrow.Day == parsed) 
            {
                result.Date = new DateTime(tomorrow.Year, tomorrow.Month, tomorrow.Day);
            }

            return result;
        }

        private static void AddGroupToTables(List<List<TableRow>> groupTables, List<TableRow> groupItem)
        {
            if (groupItem.Count > 0)
            {
                groupTables.Add(groupItem);
            }
        }

        private static void AddGroupToResult(ExtractResult result, ExtractGroup group)
        {
            if (!string.IsNullOrEmpty(group.Name))
            {
                result.Groups.Add(new ExtractGroup
                {
                    Name = group.Name,
                    Subjects = group.Subjects,
                });
            }
        }
    }
}