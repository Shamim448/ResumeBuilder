using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Repositories
{
    public interface ICVTemplateRepository : IRepositoryBase<CVTemplate, Guid>
    {
    }
}
