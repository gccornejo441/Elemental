using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AndrewLock_Calculator.Pages.MoreList
{
    public class SelectListModel : PageModel
    {
        [BindProperty]
        public IEnumerable<string> SelectedValues { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; } = new List<SelectListItem>
        {

            new SelectListItem
                {
                    Value = "js",
                    Text = "JavaScript",
                    Group = new SelectListGroup { Name = "Dynamic" },
                },
                new SelectListItem
                {
                    Value = "cpp",
                    Text = "C++",
                    Group = new SelectListGroup { Name = "Static" },
                },
                 new SelectListItem
                 {
                     Value = "csharp",
                     Text = "C#",
                 }
        };

        public void OnGet()
        {
        }
    }
}
