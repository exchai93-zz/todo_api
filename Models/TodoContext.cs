using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<ToDoContext> options)
            : base(options)
            {
            }

            public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}