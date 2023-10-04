using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Domain.Entities.CV
{
    public class MyResume : IEntity<Guid>
    {
        [Display(Name="ResumeID")]
        public Guid Id { get; set; }
        public string? ResumeName { get; set; }
        public DateTime ResumeCreateDate { get; set; }
        public Guid UserId { get; set; }
        public Guid TemplateId { get; set; }
        public virtual PersonalInfo? PersonalInfo { get; set; } 

    }
}
