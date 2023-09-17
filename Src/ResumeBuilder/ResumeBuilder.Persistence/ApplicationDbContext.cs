using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;

using ResumeBuilder.Persistence;
using ResumeBuilder.Persistence.Membership;

namespace ResumeBuilder.Persistence
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Applicant> Applicants { get ; set ; }
        public DbSet<Education> Educations { get; set; }

    }
}