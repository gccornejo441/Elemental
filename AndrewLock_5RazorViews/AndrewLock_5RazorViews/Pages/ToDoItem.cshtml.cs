using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndrewLock_5RazorViews.Pages
{
    public class ToDoItemModel : PageModel
    {
        public List<string> Tasks { get; set; }
        public string Title { get; set; }
        public bool IsComplete { get; set; }
        public void OnGet(int id)
        {
            IsComplete = false;
            Title = "Tasks for today";
            Tasks = new List<string>{
                "Chicken",
                "Talapia",
            };
        }
    }
}
