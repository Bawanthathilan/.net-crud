using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext:DbContext
    {
        
        public DbSet<Todo> todos { get; set; }
        public DbSet<Author> authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var connectionString = "server=localhost;database=myTodoDb;user=root;password=1998102910@aB";
            optionsBuilder.UseMySQL(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] {

                new Author {Id=1, FullName="Bawantha Thilan"},
                new Author {Id=2, FullName="John Doe"},
                new Author {Id=3, FullName="John Carm"},
                new Author {Id=4, FullName="Garfield"}

            });
            modelBuilder.Entity<Todo>().HasData(new Todo[] {
            new Todo
            {
                Id = 1,
                Title = "Get books from school",
                Description = "get some text book for school",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1

            },
            new Todo
            {
                Id = 2,
                Title = "Get books from school 2",
                Description = "get some text book for school 2",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 2

            },
            new Todo
            {
                Id = 3,
                Title = "Get books from school 3",
                Description = "get some text book for school 3",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 2

            },
            new Todo
            {
                Id = 4,
                Title = "Get books from school 4",
                Description = "get some text book for school 4",
                CreatedAt = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 2

            } }

            );
        }
    }
}
