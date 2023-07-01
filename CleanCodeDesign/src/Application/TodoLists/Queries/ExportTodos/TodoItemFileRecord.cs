using CleanCodeDesign.Application.Common.Mappings;
using CleanCodeDesign.Domain.Entities;

namespace CleanCodeDesign.Application.TodoLists.Queries.ExportTodos;
public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
