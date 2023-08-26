using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Web.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize]
    public class ResumeController : Controller
    {
        public IActionResult ResumeBuilder()
        {
            return View();
        }
    }
}
