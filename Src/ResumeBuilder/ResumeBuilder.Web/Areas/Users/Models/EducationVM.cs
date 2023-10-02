using Autofac;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;
using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Web.Areas.Users.Models
{
    public class EducationVM
    {
        [Required]
        [StringLength(50)]
        public string? Institution { get; set; }
        [Required]
        [StringLength(50)]
        public string? Degree { get; set; }
        [Required]
        [StringLength(50)]
        public string? City { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }

        public EducationVM()
        {
            
        }
        
        private IResumeBuilderService _resumeBuilderService;
        public EducationVM(IResumeBuilderService resumeBuilderService)
        {
            _resumeBuilderService = resumeBuilderService;

        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _resumeBuilderService = scope.Resolve<IResumeBuilderService>();

        }
        
    }
}
