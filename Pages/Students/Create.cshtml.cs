using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityManager.Data;
using UniversityManager.Models;

namespace UniversityManager.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly UniversityManager.Data.SchoolContext _context;

        public CreateModel(UniversityManager.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Student = new Student { EnrollmentDate = DateTime.Now, FirstMidName = "Joe", LastName = "Smith" };
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudent = new Student();

            if (await TryUpdateModelAsync<Student>(
                emptyStudent,
                "student",   // Prefix for form value.
                s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate))
            {
                _context.Students.Add(emptyStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}