using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewLock_5RazorViews
{
    public class ToDoService
    {
        public List<ToDoItem> AllItems { get; } = new List<ToDoItem>
        {
            new ToDoItem(1, "Buy milk", "Buy eggs", "Buy bread"),
        };
    }
}
