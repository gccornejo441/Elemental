using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AndrewLock_Calculator.Pages.Shared.MoreList
{
    public class EmployeeViewModel : PageModel
    {
        [BindProperty]
        public EmployeeInput Input { get; set; }
        // Only works with SelectListItem Class
        public IEnumerable<SelectListItem> Items { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{ Value = "gabriel", Text = "Gabriel" },
        };

        public void OnGet()
        {

        }

        public class EmployeeInput
        {
            public string SelectedValue1 { get; set; }
            public IEnumerable<string> MultiValues { get; set; }
        }
    }
}
