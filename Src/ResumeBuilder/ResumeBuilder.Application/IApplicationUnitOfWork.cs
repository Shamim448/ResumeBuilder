
using ResumeBuilder.Application.Features.Resume.Repositories;
using ResumeBuilder.Domain.UnitOfWorks;

namespace ResumeBuilder.Application
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IResumeRepository Resumes { get; }
    }
}