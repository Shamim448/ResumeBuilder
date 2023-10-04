
using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.CV;
using ResumeBuilder.Domain.Entities.ListType;
using System.Net.Http;

namespace ResumeBuilder.Infrastructure.Features.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        public ResumeService(IApplicationUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork;
            
        }
        //Create Resume
        public void CreateResume(string resumeName, Guid? UserId, PersonalInfo personalInfo)
        {
            MyResume myResume = new MyResume()
            { 
                ResumeName = resumeName,
                ResumeCreateDate = DateTime.Now,
                TemplateId = Guid.NewGuid(),
                UserId = (Guid)UserId,             
            };
            var personal = new PersonalInfo()
            {
                Name = personalInfo.Name,
                Email = personalInfo.Email,
                Phone = personalInfo.Phone,
                Address = personalInfo.Address,
                PhotoUrl = personalInfo.PhotoUrl,
                Resume = myResume
            };
            myResume.PersonalInfo = personal;
            _unitOfWork.Resumes.Add(myResume);
            _unitOfWork.Save();
        }
        //view list of resume
        public IList<MyResume> GetAllResumes()
        {
            return _unitOfWork.Resumes.GetAll();
        }

        public PersonalInfo GetResume(Guid id)
        {
            return _unitOfWork.PersonalInfos.GetById(id);            
        }

        
    }
}
