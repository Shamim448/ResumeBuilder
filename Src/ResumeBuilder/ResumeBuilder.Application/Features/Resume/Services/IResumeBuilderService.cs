using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Services
{
    public interface IResumeBuilderService
    {
        IList<Applicant> GetAllApplicant();
    }
}
