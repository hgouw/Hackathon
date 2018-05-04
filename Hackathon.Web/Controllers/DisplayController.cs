using System.Web.Mvc;
using Hackathon.DataAccess;

namespace Hackathon.Web.Controllers
{
    public class DisplayController : Controller
    {
        [Route("Display")]
        public ActionResult Default ()
        {
            using (var api = new Api())
            {
            }

           return View();
        }
    }
}