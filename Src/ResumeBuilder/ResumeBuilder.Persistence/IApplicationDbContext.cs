using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Persistence.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence
{
    public interface IApplicationDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
