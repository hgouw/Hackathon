using System.Web.Mvc;

namespace Hackathon.Web.Controllers
{
    public class ChartController : Controller
    {
        [Route("GoogleChart")]
        public ActionResult Default()
        {
            return View();
        }
    }
}