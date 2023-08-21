using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Web.Areas.Users.Models;

namespace ResumeBuilder.Web.Areas.Users.Controllers
{
    [Area("Users")]
    public class ResumeController : Controller
    {
        [Area("Users")]
        public IActionResult ResumeBuilder()
        {
            //var model = new ResumeBuilderModel();
            return View();
        }
    }
}
