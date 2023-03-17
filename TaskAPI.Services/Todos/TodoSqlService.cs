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
        public List<Todo> AllTodos(int authorId)
        {
            return _context.todos.Where(t => t.AuthorId == authorId).ToList();
        }

        public Todo GetTodo(int authorId,int id)
        {
            return _context.todos.FirstOrDefault(t => t.Id == id && t.AuthorId == authorId);
        }
    }
}

