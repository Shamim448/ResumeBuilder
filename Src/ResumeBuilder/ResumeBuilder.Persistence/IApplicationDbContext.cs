using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;
using ResumeBuilder.Domain.Entities.SectionType;
using ResumeBuilder.Persistence.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence
{
    public interface IApplicationDbContext
    {
        public DbSet<Education> Educations { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<CVTemplate> CVTemplates { get; set; }
    }
}
