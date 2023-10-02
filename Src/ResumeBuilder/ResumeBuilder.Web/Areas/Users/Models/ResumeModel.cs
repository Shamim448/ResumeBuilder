using Autofac;
using Microsoft.AspNetCore.Cors.Infrastructure;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.CV;
using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Web.Areas.Users.Models
{
    public class ResumeModel
    {
        [MaxLength(100)]
        [Required]
        public string? ResumeName { get; set; }
        public DateTime? ResumeCreateDate { get; set; }

        public ResumeModel()
        {

        }
        private IResumeBuilderService _resumeBuilderService;
        public ResumeModel(IResumeBuilderService resumeBuilderService)
        {
            _resumeBuilderService = resumeBuilderService;

        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _resumeBuilderService = scope.Resolve<IResumeBuilderService>();

        }
        internal IList<MyResume> GetResumes()
        {
            return _resumeBuilderService.GetAllResumes();
        }

    }
}
