using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Services
{
    public interface IResumeBuilderService
    {
        

        void CreateAResume(string fname, string mname, string lname, string Designation,
            string Address, string Email, string Phone, string summary, IList<Education> educations);
        IList<Applicant> GetAllApplicant();
    }
}
