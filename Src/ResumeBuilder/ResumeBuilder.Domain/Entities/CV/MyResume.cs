
namespace ResumeBuilder.Domain.Entities.CV
{
    public class MyResume : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string ResumeName { get; set; }
        public DateTime ResumeCreateDate { get; set; }
    }
}
