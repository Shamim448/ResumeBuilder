using Autofac;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Persistence;
using ResumeBuilder.Persistence.Membership;
using ResumeBuilder.Web.Areas.Users.Models;


namespace ResumeBuilder.Web.Areas.Users.Controllers
{
    [Area("Users")]
    
    public class ResumeController : Controller
    {
        ILifetimeScope _scope;
        ILogger<ResumeController> _logger;
        private readonly IApplicationDbContext _context;
        private Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        public ResumeController(ILifetimeScope scope, ILogger<ResumeController> logger, IApplicationDbContext context,
            Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _scope = scope;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
           var model = _scope.Resolve<ResumeListModel>();           
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = _scope.Resolve<ResumeCreateModel>();           
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ResumeCreateModel model)
        {
            model.ResolveDependency(_scope);
            var userid = _userManager.GetUserId(HttpContext.User);
            model.UserId = new Guid(userid);
            if (ModelState.IsValid)
            {
                model.CreateAResume();
            }            
           return RedirectToAction("Index", "Home");    
        }

        public IActionResult ResumeBuilder()
        {
            return View();
        }
    }
}
