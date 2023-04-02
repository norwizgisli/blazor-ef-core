using BlazorEfCoreTest.Context;
using BlazorEfCoreTest.Models;
using Microsoft.EntityFrameworkCore;
using SqliteWasmHelper;

namespace BlazorEfCoreTest.Services
{
    public class TodoService
    {
        private readonly ISqliteWasmDbContextFactory<TodoContext> _factory;

        public TodoService(ISqliteWasmDbContextFactory<TodoContext> factory)
        {
            _factory = factory;
        }

        public async Task< List<TodoItem>> GetItems()
        {
            using var context = await _factory.CreateDbContextAsync();
            return await context.TodoItem.ToListAsync();
        }

        public async Task AddItem(TodoItem item)
        {
            using var context = await _factory.CreateDbContextAsync();

            context.TodoItem.Add(item);
            await context.SaveChangesAsync();
        }

        public async Task UpdateItem(TodoItem item)
        {
            using var context = await _factory.CreateDbContextAsync();

            context.TodoItem.Update(item);
            await context.SaveChangesAsync();
        }
    }
}
