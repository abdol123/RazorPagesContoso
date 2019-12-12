using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AH_RazorPagesContoso.Models
{
    public class ContosoContext : DbContext
    {
        public ContosoContext (DbContextOptions<ContosoContext> options)
            : base(options)
        {
        }

        public DbSet<AH_RazorPagesContoso.Models.Student> Student { get; set; }
    }
}
