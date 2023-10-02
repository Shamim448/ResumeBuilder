using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.CV;
using ResumeBuilder.Domain.Entities.ListType;

namespace ResumeBuilder.Infrastructure.Features.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;


        public ResumeService(IApplicationUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork;
            
        }

        public IList<MyResume> GetResumes()
        {
            return _unitOfWork.Resumes.GetAll();
        }
    }
}
