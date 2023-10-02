using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities.CV;
using ResumeBuilder.Persistence;


namespace ResumeBuilder.Application.Features.Resume.Repositories
{

    public class ResumeRepository : Repository<MyResume, Guid>, IResumeRepository
    {
        public ResumeRepository(IApplicationDbContext dbContext)
            : base((DbContext)dbContext)
        {

        }
    }
}
