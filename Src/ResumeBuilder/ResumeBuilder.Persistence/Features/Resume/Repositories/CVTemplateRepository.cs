using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;
using ResumeBuilder.Domain.Repositories;
using ResumeBuilder.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Repositories
{
   
    public class CVTemplateRepository : Repository<CVTemplate, Guid>, ICVTemplateRepository
    {
        public CVTemplateRepository(IApplicationDbContext dbContext)
            : base((DbContext)dbContext)
        {
        }
    }
}
