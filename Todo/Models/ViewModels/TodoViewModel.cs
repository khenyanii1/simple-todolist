using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models.ViewModels
{
    public class TodoViewModel
    {
        public List<TodoItem> TodoList { get; set; }
        public TodoItem Todo { get; set; }
    }
}