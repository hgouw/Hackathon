using System.Web.Mvc;

namespace Hackathon.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Default()
        {
            return View();
        }
    }
}