


using ResumeBuilder.Application.Features.Resume.Repositories;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.UnitOfWorks;

namespace ResumeBuilder.Application
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IApplicantRepository Applicants { get; }
        IEducationRepository Educations { get; }
        IResumeRepository Resumes { get; }

    }
}