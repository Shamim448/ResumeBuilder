using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.Web.Models
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and confirm password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
