using Autofac;

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

      

        public ApplicantVM()
        {

        }
       

       
    }
}
