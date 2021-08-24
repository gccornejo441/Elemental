using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewLock_Calculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public void OnGet()
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "The validation succeeded, but here's a model error for you!");
            }
        }

        public class InputModel
        {
            [Display(Name = "Your name")]
            public string FirstName { get; set; } = "Enter your first name";
            public string LastName { get; set; } = "Enter your last name";


        }
    }
}
