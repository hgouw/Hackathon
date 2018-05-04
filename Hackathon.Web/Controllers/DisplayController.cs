using System.Web.Mvc;

namespace Hackathon.Web.Controllers
{
    public class DisplayController : Controller
    {
        [Route("Display")]
        public ActionResult Default ()
        {
            return View();
        }
    }
}