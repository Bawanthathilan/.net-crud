using System.ComponentModel.DataAnnotations;
using TaskAPI.Models;

namespace Crud.Models
{
    public class Todo
    {
       public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedAt { get; set;}
        [Required]
        public DateTime Due { get; set; }
        [Required]

        public TodoStatus Status { get; set; } //New, InProgress , Complete

       public int AuthorId { get; set; }
       public Author Author { get; set; }
    }
}
