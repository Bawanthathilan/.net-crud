using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;



namespace TaskAPI.DataAccess
{
    public class TodoDbContext:DbContext
    {
        public DbSet<Todo> todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var connectionString = "server=localhost;database=myTodoDb;user=root;password=1998102910@aB";
            optionsBuilder.UseMySQL(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "Get books from school",
                Description = "get some text book for school",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            });
        }
    }
}
