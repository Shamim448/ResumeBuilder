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

        private IResumeService _resumeBuilderService;
        public ResumeListModel()
        {

        } 
        public ResumeListModel(IResumeService resumeBuilderService)
        {
            _resumeBuilderService = resumeBuilderService;

        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _resumeBuilderService = scope.Resolve<IResumeService>();

        }
        internal IList<MyResume> GetResumes()
        {
            return _resumeBuilderService.GetAllResumes();
        }

    }
}
