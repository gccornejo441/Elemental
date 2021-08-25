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
        public void OnGet()
        {

        }

        public IEnumerable<SelectListItem> Items { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{Text = "JavaScript Developer", Value = "JavaScript Developer" }
        };

        public class EmployeeInput
        {
            [Display(Name = "Job Title")]
            public string SelectItems1 { get; set; }
        };

    }
}
