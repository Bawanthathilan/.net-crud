using AutoMapper;
using Crud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace Crud.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository , IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<Todo>> GetTodos(int authorId)
        {
            var myTodos = _todoService.AllTodos(authorId);
            var mapTodos = _mapper.Map<ICollection<TodoDto>>(myTodos);
            return Ok(mapTodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorId,int id)
        {
            var myTodo = _todoService.GetTodo(authorId,id);
            
            if(myTodo is null)
            {
                return NotFound();
            }
            var mappedTodo =_mapper.Map<TodoDto>(myTodo);
            return Ok (mappedTodo);
        }
        
    }
}
