using ResumeBuildero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities.SectionType
{
    public class AboutUs : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string? FName { get; set; }
        public string? MName { get; set; }
        public string? LName { get; set; }
        public string? Designation { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        public string? Summary { get; set; }

        //one to one
        public CVTemplate CVTemplate { get; set; }
        public Guid CVTemplateId { get; set; }
    }
}
