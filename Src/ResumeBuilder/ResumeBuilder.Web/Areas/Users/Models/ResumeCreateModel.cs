using Autofac;
using ResumeBuilder.Application.Features.Resume.Services;
using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Web.Areas.Users.Models
{
    public class ResumeCreateModel
    {
        [MaxLength(100)]
        [Required]
        public string ResumeName { get; set; }
        public Guid? UserId { get; set; }
        public Guid? TemplateId { get; set; }

        private IResumeService _resumeService;
        public ResumeCreateModel()
        {

        }
        public ResumeCreateModel(IResumeService resumeService)
        {
            _resumeService = resumeService;

        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _resumeService = scope.Resolve<IResumeService>();

        }
        internal void CreateAResume()
        {
            if(!string.IsNullOrEmpty(ResumeName))
            {
                _resumeService.CreateResume(ResumeName, UserId);
            }
        }
    }
}
