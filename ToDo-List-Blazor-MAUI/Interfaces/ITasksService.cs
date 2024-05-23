using ToDo_List_Blazor_MAUI.Data;

namespace ToDo_List_Blazor_MAUI.Interfaces
{
    public interface ITasksService
    {
        void CreateTableTodo();
        void AddTodo(Todo todo);
        void UpdateTodo(Todo todo);
        void DeleteTodo(int Id);
        List<Todo> GetTodos();
        Todo GetTodo(int Id);
    }
}