using System.Globalization;
using CleanCodeDesign.Application.Common.Interfaces;
using CleanCodeDesign.Application.TodoLists.Queries.ExportTodos;
using CleanCodeDesign.Infrastructure.Files.Maps;
using CsvHelper;

namespace CleanCodeDesign.Infrastructure.Files;
public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
