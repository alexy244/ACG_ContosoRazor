﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ACG_CoreRazorContoso.Models;

namespace ACG_CoreRazorContoso.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly ACG_CoreRazorContoso.Models.UniversityContext _context;

        public DetailsModel(ACG_CoreRazorContoso.Models.UniversityContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.CourseID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
