using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.CV;
<<<<<<< HEAD
=======
using ResumeBuilder.Domain.Entities.ListType;
>>>>>>> 3e901c7136dabbf77070fc92dbd8d7cad2694857
using ResumeBuilder.Persistence.Membership;

namespace ResumeBuilder.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;
        public ApplicationDbContext(string connectionString, string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString,
                    x => x.MigrationsAssembly(_migrationAssembly));
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            base.OnModelCreating(optionsBuilder);
        }
        public DbSet<Applicant> Applicants { get ; set ; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<MyResume> Resumes { get; set; }

    }
}