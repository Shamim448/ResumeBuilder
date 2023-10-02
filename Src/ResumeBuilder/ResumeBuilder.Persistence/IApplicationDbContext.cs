
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities.CV;

namespace ResumeBuilder.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<MyResume> Resumes { get; set; }
    }
}
