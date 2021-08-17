using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndrewLock_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var url = Url.Page("Currency/View", new { code = "USD" });
        }
    }
}
