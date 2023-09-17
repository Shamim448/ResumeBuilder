using ResumeBuilder.Domain.Entities.SectionType;
using ResumeBuilder.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Repositories
{
    public interface IAboutUsRepository : IRepositoryBase<AboutUs, Guid>
    {
    }
}
