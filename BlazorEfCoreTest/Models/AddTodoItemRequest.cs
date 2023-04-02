using System.ComponentModel.DataAnnotations;

namespace BlazorEfCoreTest.Models
{
    public class AddTodoItemRequest
    {
        [Required(ErrorMessage ="Must set description")]
        public string Description { get; set; }
    }
}
