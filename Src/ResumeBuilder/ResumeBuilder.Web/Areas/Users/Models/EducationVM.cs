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
    }
}
