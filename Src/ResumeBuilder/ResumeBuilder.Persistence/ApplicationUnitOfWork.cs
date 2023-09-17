﻿
using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Application;
using ResumeBuilder.Application.Features.Resume.Repositories;

namespace ResumeBuilder.Persistence
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IApplicantRepository Applicants { get; private set; }
        public IEducationRepository Educations { get; private set; }
        public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            IApplicantRepository applicantRepository, IEducationRepository educationRepository
            ) : base((DbContext) dbContext)
        {
            Applicants = applicantRepository;
            Educations = educationRepository;
        }  
    }
}