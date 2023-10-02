﻿using Autofac;
using Microsoft.AspNetCore.Mvc;
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
           var model = _scope.Resolve<ResumeModel>();
        
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = _scope.Resolve<ApplicantVM>();
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ApplicantVM model)
        {
            if (ModelState.IsValid)
            {
                model.CreateResume();
            }
            
            
           return RedirectToAction("Index", "Home");    
        }

        public IActionResult ResumeBuilder()
        {
            return View();
        }
    }
}
