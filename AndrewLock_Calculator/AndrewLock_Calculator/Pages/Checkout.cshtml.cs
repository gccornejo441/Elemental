using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndrewLock_Calculator.Pages
{
    public class CheckoutModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }
        public void OnGet()
        {
        }

        public class InputModel
        {
            [Required]
            [StringLength(100, ErrorMessage = "Maxium length is {1}")]
            [Display(Name = "Your Name")]
            public string FirstName { get; set; }
        }
    }
}
