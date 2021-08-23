using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewLock_NestedViews.Pages
{
    public class TaskService
    {
        //This list would be loaded from a database or file etc
        public static List<ToDoItemViewModel> AllTasks = new List<ToDoItemViewModel>
        {
            new ToDoItemViewModel(1, "Things to buy at the grocery store", "Protein powerder, Flour tortillas")
        };
    }
}
