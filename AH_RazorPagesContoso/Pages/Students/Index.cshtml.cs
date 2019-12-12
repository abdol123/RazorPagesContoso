using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AH_RazorPagesContoso.Models;

namespace AH_RazorPagesContoso.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly AH_RazorPagesContoso.Models.ContosoContext _context;

        public IndexModel(AH_RazorPagesContoso.Models.ContosoContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
