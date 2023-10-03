
using ResumeBuilder.Domain.Entities.CV;

namespace ResumeBuilder.Application.Features.Resume.Services
{
    public interface IResumeService
    {
        void CreateResume(string resumeName, Guid? UserId);
        IList<MyResume> GetAllResumes();
    }
}
