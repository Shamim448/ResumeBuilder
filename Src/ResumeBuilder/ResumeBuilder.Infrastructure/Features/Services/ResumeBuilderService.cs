using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Services;


namespace ResumeBuilder.Infrastructure.Features.Services
{
    public class ResumeBuilderService : IResumeBuilderService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;


        public ResumeBuilderService(IApplicationUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork;
            
        }
    }
}
