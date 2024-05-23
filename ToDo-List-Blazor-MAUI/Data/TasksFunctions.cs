using Microsoft.Data.Sqlite;
using ToDo_List_Blazor_MAUI.Interfaces;

namespace ToDo_List_Blazor_MAUI.Data
{
    public class TasksFunctions : ITasksService
    {
        public void CreateTableTodo()
        {
            string sqlExpression = "CREATE TABLE IF NOT EXISTS Tasks(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT NOT NULL, Date TEXT NOT NULL, Priority TEXT NOT NULL, Status TEXT NOT NULL, Content TEXT NOT NULL);";
            using (var connection = new SqliteConnection("Data Source=tasks.db"))
            {
                connection.Open();
                using (var command = new SqliteCommand(sqlExpression, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddTodo(Todo todo)
        {
            string sqlExpression = "INSERT INTO Tasks (Name, Date, Priority, Status, Content) VALUES (@Name, @Date, @Priority, @Status, @Content);";
            using (var connection = new SqliteConnection("Data Source=tasks.db"))
            {
                connection.Open();
                using (var command = new SqliteCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@Name", todo.Name);
                    command.Parameters.AddWithValue("@Date", todo.Date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Priority", todo.Priority);
                    command.Parameters.AddWithValue("@Status", todo.Status);
                    command.Parameters.AddWithValue("@Content", todo.Content);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTodo(Todo todo)
        {
            string sqlExpression = "Update Tasks SET Name = @Name, Date = @Date, Priority = @Priority, Status = @Status, Content = @Content WHERE Id = @Id;";
            using (var connection = new SqliteConnection("Data Source=tasks.db"))
            {
                connection.Open();
                using (var command = new SqliteCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@Name", todo.Name);
                    command.Parameters.AddWithValue("@Date", todo.Date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Priority", todo.Priority);
                    command.Parameters.AddWithValue("@Status", todo.Status);
                    command.Parameters.AddWithValue("@Content", todo.Content);
                    command.Parameters.AddWithValue("@Id", todo.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTodo(int Id)
        {
            string sqlExpression = "DELETE FROM Tasks WHERE Id = @Id;";
            using (var connection = new SqliteConnection("Data Source=tasks.db"))
            {
                connection.Open();
                using (var command = new SqliteCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Todo> GetTodos()
        {
            List<Todo> Todos = new List<Todo>();
            string sqlExpression = "SELECT * FROM Tasks;";
            using (var connection = new SqliteConnection("Data Source=tasks.db"))
            {
                connection.Open();
                using (var command = new SqliteCommand(sqlExpression, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Todo todo = new Todo
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = Convert.ToString(reader["Name"]),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    Priority = Convert.ToString(reader["Priority"]),
                                    Status = Convert.ToString(reader["Status"]),
                                    Content = Convert.ToString(reader["Content"])
                                };
                                Todos.Add(todo);
                            }
                        }
                    }
                }
            }
            return Todos;
        }

        public Todo GetTodo(int Id)
        {
            Todo todo = new Todo();
            string sqlExpression = "SELECT * FROM Tasks WHERE Id = @Id;";
            using (var connection = new SqliteConnection("Data Source=tasks.db"))
            {
                connection.Open();
                using (var command = new SqliteCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            todo = new Todo
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = Convert.ToString(reader["Name"]),
                                Date = Convert.ToDateTime(reader["Date"]),
                                Priority = Convert.ToString(reader["Priority"]),
                                Status = Convert.ToString(reader["Status"]),
                                Content = Convert.ToString(reader["Content"])
                            };
                        }
                    }
                }
            }
            return todo;
        }
    }
}
