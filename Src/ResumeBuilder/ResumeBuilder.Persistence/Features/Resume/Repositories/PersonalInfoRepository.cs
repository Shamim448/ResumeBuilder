using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities.CV;
using ResumeBuilder.Persistence;


namespace ResumeBuilder.Application.Features.Resume.Repositories
{

    public class PersonalInfoRepository : Repository<PersonalInfo, Guid>, IPersonalInfoRepository
    {
        public PersonalInfoRepository(IApplicationDbContext dbContext)
            : base((DbContext)dbContext)
        {

        }
    }
}
