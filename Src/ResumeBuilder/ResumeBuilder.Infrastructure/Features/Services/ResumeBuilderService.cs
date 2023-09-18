using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;

namespace ResumeBuilder.Infrastructure.Features.Services
{
    public class ResumeBuilderService : IResumeBuilderService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;


        public ResumeBuilderService(IApplicationUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork;
            
        }

        public IList<Applicant> GetAllApplicant()
        {
           return _unitOfWork.Applicants.GetAll();
        }
    }
}
