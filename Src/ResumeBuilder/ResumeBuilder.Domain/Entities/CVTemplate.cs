using ResumeBuilder.Domain.Entities.ListType;
using ResumeBuilder.Domain.Entities.SectionType;
using ResumeBuildero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities
{
    public class CVTemplate : IEntity<Guid>
    {
        public Guid Id { get; set ; }
        public AboutUs? AboutUsSection { get; set ; }
        public IList<Education>? Educations { get; set ; }
    }
}
