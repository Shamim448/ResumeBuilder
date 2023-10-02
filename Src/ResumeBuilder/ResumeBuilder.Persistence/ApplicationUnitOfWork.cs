
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Repositories;

namespace ResumeBuilder.Persistence
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IResumeRepository Resumes { get; private set; }

        public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            IResumeRepository resumeRepository
            ) : base((DbContext)dbContext)
        {
            Resumes = resumeRepository;

        }
    }
}
