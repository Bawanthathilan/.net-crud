using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace Crud.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service , IMapper mapper)
        {
            _service= service;
            _mapper= mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors()
        {
            var authors = _service.GetAllAuthors();
            
            var mapAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
        
            return Ok(mapAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id) {

            throw new Exception("Test Error");
            var author = _service.GetAuthor(id);

            if(author is null)
            {
                return NotFound();
            }
            var mappedAuthor = _mapper.Map<AuthorDto>(author);
            return Ok(mappedAuthor);
        }
    }
}
