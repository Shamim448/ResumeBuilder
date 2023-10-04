using Autofac;
using Microsoft.AspNetCore.Identity;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities.CV;
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

        public virtual PersonalInfo? PersonalInfo { get; set; } 

        private IResumeService _resumeService;
        private UserManager<IdentityUser> _userManager;
        public ResumeCreateModel()
        {

        }
        public ResumeCreateModel(IResumeService resumeService,
            UserManager<IdentityUser> userManager)
        {
            _resumeService = resumeService;
        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _resumeService = scope.Resolve<IResumeService>();

        }
        internal void CreateAResume()
        {          
            if (!string.IsNullOrEmpty(ResumeName))
            {
                _resumeService.CreateResume(ResumeName, UserId, PersonalInfo);
            }
        }

        
    }
}
