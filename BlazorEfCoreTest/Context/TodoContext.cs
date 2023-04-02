using BlazorEfCoreTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEfCoreTest.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItem { get; set; } = null!;
    }
}
