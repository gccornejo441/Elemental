using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AndrewLock_Calculator.Pages
{
    public class SelectListsModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }
        public void OnGet()
        {
        }
    public IEnumerable<SelectListItem> Items { get; set; } = new List<SelectListItem>
    {
        new SelectListItem{Value= "csharp", Text="C#"},
 new SelectListItem{Value= "python", Text= "Python"},
 new SelectListItem{Value= "cpp", Text="C++"},
 new SelectListItem{Value= "java", Text="Java"},
 new SelectListItem{Value= "js", Text="JavaScript"},
 new SelectListItem{Value= "ruby", Text="Ruby"},
    };

    public class InputModel
    {
            // Used to hold value.  Model bound to the value.  Used to preselect the correct item.
        public string SelectedValue1 { get; set; }
        public string SelectedValue2 { get; set; }
        public IEnumerable<string> MultiValues { get; set; }
    }
    }
}
