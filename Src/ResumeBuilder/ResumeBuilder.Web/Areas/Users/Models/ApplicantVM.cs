using Autofac;
using Microsoft.AspNetCore.Cors.Infrastructure;
using ResumeBuilder.Application.Features.Resume.Services;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Web.Areas.Users.Models
{
    public class ApplicantVM
    {
        [Required]
        [StringLength(150)]
        [DisplayName("First Name")]
        public string? FName { get; set; }
        
        [StringLength(150)]
        [DisplayName("Middle Name (Optional)")]
        public string? MName { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Last Name")]
        public string? LName { get; set; }
        
        public string? Designation { get; set; }
        [Required]
        [StringLength(250)]
        public string? Address { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [StringLength(15)]
        public string? PhoneNo { get; set; }
        [Required]
        [StringLength(300)]
        public string? Summary { get; set; }

        public IList<Education>? Educations { get; set; } /*= new List<Education>();*/

        public ApplicantVM()
        {

        }
        private IResumeBuilderService _resumeBuilderService;
        public ApplicantVM(IResumeBuilderService resumeBuilderService)
        {
            _resumeBuilderService = resumeBuilderService;
            
        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _resumeBuilderService = scope.Resolve<IResumeBuilderService>();
           
        }
        internal IList<Applicant> GetApplicants()
        {
            return _resumeBuilderService.GetAllApplicant();
        }

        public void CreateResume()
        {
            _resumeBuilderService.CreateAResume(FName,MName, LName, Designation,Address, Email, PhoneNo, Summary, Educations);
        }
    }
}
