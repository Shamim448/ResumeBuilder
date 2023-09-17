using ResumeBuildero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities.ListType
{
    public class Education : IEntity<Guid>
    {
        public Guid Id { get; set; }        
        public string? Institution { get; set; }
        public string? Degree { get; set; }
        public string? City { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
       
        //one to one
        public Applicant Applicant { get; set; }
        [ForeignKey("Applicant")]
        public Guid ApplicantId { get; set; }

    }
}
