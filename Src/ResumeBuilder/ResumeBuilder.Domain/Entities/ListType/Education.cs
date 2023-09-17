using ResumeBuildero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities.ListType
{
    public class Education : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string? Degree { get; set; }
        public string? Institution { get; set; }
        public int? GraduationYear { get; set; }
        public double? CGPA { get; set; }
        public string? MajorField { get; set; }

        //one to one
        public CVTemplate CVTemplate { get; set; }
        public Guid CVTemplateId { get; set; }

    }
}
