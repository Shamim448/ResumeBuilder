using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;



namespace ResumeBuilder.Infrastructure.Features.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public ResumeService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
    }
}
