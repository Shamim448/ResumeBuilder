using ResumeBuilder.Domain.Entities.ListType;
using ResumeBuilder.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Repositories
{
    public interface IEducationRepository : IRepositoryBase<Education, Guid>
    {

    }
}
