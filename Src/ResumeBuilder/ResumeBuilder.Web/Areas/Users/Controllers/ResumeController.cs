using Autofac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Domain.Entities.ListType;
using ResumeBuilder.Persistence;
using ResumeBuilder.Web.Areas.Users.Models;

namespace ResumeBuilder.Web.Areas.Users.Controllers
{
    [Area("Users")]
    
    public class ResumeController : Controller
    {
        ILifetimeScope _scope;
        ILogger<ResumeController> _logger;
        private readonly IApplicationDbContext _context;
        public ResumeController(ILifetimeScope scope, ILogger<ResumeController> logger, IApplicationDbContext context)
        {
            _logger = logger;
            _scope = scope;
            _context = context;
        }
        public IActionResult Index()
        {
            List<Applicant> applicants;
            applicants = _context.Applicants.ToList();
            return View(applicants);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Applicant applicant = new Applicant();
            applicant.Educations.Add(new Education() { Id = new Guid("7D688CCB-624A-46A4-AB08-24E0795B947B") });
            return View(applicant);
        }
        [HttpPost]
        public IActionResult Create(Applicant applicant)
        {
            
           return RedirectToAction("Index", "Home");    
        }
        public IActionResult ResumeBuilder()
        {
            return View();
        }
    }
}
