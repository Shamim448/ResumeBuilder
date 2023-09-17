using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Application.Features.Resume.Repositories;
using ResumeBuilder.Domain.Entities.SectionType;
using ResumeBuilder.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence.Features.Resume.Repositories
{
    public class AboutUsRepository : Repository<AboutUs, Guid>, IAboutUsRepository
    {
        public AboutUsRepository(IApplicationDbContext dbContext)
            : base((DbContext)dbContext)
        {
        }
    }
}
