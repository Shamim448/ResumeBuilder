﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.CV;
using ResumeBuilder.Domain.Entities.ListType;

using ResumeBuilder.Persistence.Membership;

namespace ResumeBuilder.Persistence
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
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
            optionsBuilder.Entity<MyResume>()
               .HasOne(m => m.PersonalInfo)
               .WithOne(p => p.Resume)
               .HasForeignKey<PersonalInfo>(p => p.Id)
               .IsRequired();
            base.OnModelCreating(optionsBuilder);
        }
        public DbSet<Applicant> Applicants { get ; set ; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<MyResume> Resumes { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }


    }
}