using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext:DbContext
    {
        public DbSet<Todo> todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;uid=root;pwd=12345;database=test";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
