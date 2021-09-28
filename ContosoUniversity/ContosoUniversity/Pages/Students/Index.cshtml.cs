using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;
        public IndexModel(SchoolContext context)
        {
            _context = context;
        }

        public string LastNameSort { get; set; }
        public string FirstNameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Student> Students { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // using System;
            LastNameSort = String.IsNullOrEmpty(sortOrder) ? "lname_desc" : "last";
            FirstNameSort = String.IsNullOrEmpty(sortOrder) ? "fname_desc" : "first";

            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Student> studentsIQ = from s in _context.Students
                                             select s;

            switch (sortOrder)
            {
                case "lname_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.LastName);
                    break;
                case "fname_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.FirstMidName);
                    break;
                case "Date":
                    studentsIQ = studentsIQ.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.EnrollmentDate);
                    break;
                case "last":
                    studentsIQ = studentsIQ.OrderBy(s => s.LastName);
                    break;
                case "first":
                    studentsIQ = studentsIQ.OrderBy(s => s.FirstMidName);
                    break;
            }

            Students = await studentsIQ.AsNoTracking().ToListAsync();
        }
    }
}
