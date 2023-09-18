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

        public void CreateAResume(
            string fname, string mname, string lname, string Designation,
            string Address, string Email, string Phone, string summary,IList<Education> educations
            )
        {
            Applicant applicant = new Applicant()           
            { 
                FName = fname,
                MName = mname,
                LName = lname,
                Designation = Designation,
                Address = Address,
                Email = Email,
                PhoneNo = Phone,
                Summary = summary,
                Educations = educations.ToList()          
            };
            _unitOfWork.Applicants.Add( applicant );
            _unitOfWork.Save();
        }

        public IList<Applicant> GetAllApplicant()
        {
           return _unitOfWork.Applicants.GetAll();
        }
    }
}
