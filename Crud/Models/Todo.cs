namespace Crud.Models
{
    public class Todo
    {
       public int Id { get; set; }
       public string Title { get; set; }
       public string Description { get; set; }
       public DateTime CreatedAt { get; set;}
       public DateTime Due { get; set;}
       public TodoStatus Status { get; set; } //New, InProgress , Complete
    }
}
