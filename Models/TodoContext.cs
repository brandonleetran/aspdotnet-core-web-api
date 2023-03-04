using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
        // this is the use of Microsoft Entity Framework Core
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}