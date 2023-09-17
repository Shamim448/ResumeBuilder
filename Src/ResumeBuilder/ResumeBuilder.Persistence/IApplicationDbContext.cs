using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;


namespace ResumeBuilder.Persistence
{
    public interface IApplicationDbContext
    {
        
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
