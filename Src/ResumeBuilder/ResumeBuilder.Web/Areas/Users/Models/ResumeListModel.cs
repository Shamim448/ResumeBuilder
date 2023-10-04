using Autofac;
using Microsoft.AspNetCore.Cors.Infrastructure;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.CV;
using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Web.Areas.Users.Models
{
    public class ResumeListModel
    {
        [MaxLength(100)]
        [Required]
        public string? ResumeName { get; set; }
        public DateTime? ResumeCreateDate { get; set; }
        public virtual PersonalInfo? PersonalInfo { get; set; }

        private IResumeService _resumeService;
        public ResumeListModel()
        {

        } 
        public ResumeListModel(IResumeService resumeBuilderService)
        {
            _resumeService = resumeBuilderService;

        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _resumeService = scope.Resolve<IResumeService>();

        }
        internal IList<MyResume> GetResumes()
        {
            return _resumeService.GetAllResumes();
        }

        //Return single Resume
        internal MyResume ViewResume(Guid id)
        {
            MyResume resume = _resumeService.GetResume(id);
            ResumeName = resume.ResumeName;
            PersonalInfo = resume.PersonalInfo;
            return resume;
        }
    }
}
