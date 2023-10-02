
using ResumeBuilder.Domain.Entities.CV;

namespace ResumeBuilder.Application.Features.Resume.Services
{
    public interface IResumeService
    {
        IList<MyResume> GetResumes();
    }
}
