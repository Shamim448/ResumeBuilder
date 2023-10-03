using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities.CV
{
    public class PersonalInfo:IEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("MyResume")]
        public Guid ResumeId { get; set; }
        public virtual MyResume? Resume { get; set; }

        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? PhotoUrl { get; set; }


    }
}
