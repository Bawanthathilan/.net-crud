using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Services
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
    }
}
