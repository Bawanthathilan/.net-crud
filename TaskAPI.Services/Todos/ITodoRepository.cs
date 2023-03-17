using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos(int authorId);

        public Todo GetTodo(int authorId, int id);
    }
}
