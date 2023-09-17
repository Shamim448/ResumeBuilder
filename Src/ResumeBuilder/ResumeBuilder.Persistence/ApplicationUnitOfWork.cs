
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Repositories;
using ResumeBuilder.Persistence.Features.Resume.Repositories;

namespace ResumeBuilder.Persistence
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public EducationRepository Educations { get; private set; }
        public AboutUsRepository AboutUs { get; private set; }
       // public ICVTemplateRepository { get; private set; }

		public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            EducationRepository educationRepository, 
            AboutUsRepository aboutUsRepository
            ) : base((DbContext)dbContext)
        {
            Educations = educationRepository;
            AboutUs = aboutUsRepository;
        }
    }
}
