using Crud.Models;
using TaskAPI.Services;

namespace Crud.Services
{
    public class TodoService:ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "test1",
                Description = "get some text book for school",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };

            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "test2",
                Description = "get some text book for school2",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "test3",
                Description = "get some text book for school3",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo3);

            return todos;
        }
    
}
}
