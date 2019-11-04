using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ACG_CoreRazorContoso.Models;

namespace ACG_CoreRazorContoso.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ACG_CoreRazorContoso.Models.UniversityContext _context;

        public IndexModel(ACG_CoreRazorContoso.Models.UniversityContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
