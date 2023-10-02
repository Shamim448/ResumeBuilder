using ResumeBuilder.Domain.Entities.ListType;
using ResumeBuilder.Domain.Entities;


namespace ResumeBuilder.Domain.Entities
{
    public class Applicant : IEntity<Guid>
    {
        public Guid Id { get; set ; }      
        public string? FName { get; set; }
        public string? MName { get; set; }
        public string? LName { get; set; }
        public string? Designation { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        public string? Summary { get; set; }

        public IList<Education>? Educations { get; set ; } = new List<Education>();
    }
}
