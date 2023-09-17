using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities.ListType;

using ResumeBuilder.Domain.Repositories;
using ResumeBuilder.Persistence;


namespace ResumeBuilder.Application.Features.Resume.Repositories
{
   
    public class EducationRepository : Repository<Education, Guid>, IEducationRepository
    {
        public EducationRepository(IApplicationDbContext dbContext)
            : base((DbContext)dbContext)
        {
        }
    }
}
