using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos()
        {
            return _context.todos.ToList();
        }

        public Todo GetTodo(int id)
        {
            return _context.todos.Find(id);
        }
    }
}

