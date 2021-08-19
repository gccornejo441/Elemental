using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Andrewlock_ValationRes.Pages
{
    public class CheckoutModel : PageModel
    {
        [BindProperty]
        public UserBindingModel Input { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("");
        }

        public class UserBindingModel
        {
            [Required]
            [StringLength(100)]
            [Display(Name = "Your name")]
            public string FirstName { get; set; }

            [Required]
            [StringLength(100)]
            [Display(Name = "Last name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Phone (ErrorMessage ="Uhh, that doesn't work here")]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }
    }
}
