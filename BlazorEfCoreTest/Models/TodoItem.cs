namespace BlazorEfCoreTest.Models
{
    public class TodoItem
    {
        public Guid TodoItemId { get; set; }
        public string Description { get; set; } = "";
        public bool Resolved { get; set; }
    }
}
