using System;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using Hackathon.Web.Models;

namespace Hackathon.Web.Controllers
{
    public class GoogleChartController : Controller
    {
        [Route("GoogleChart")]
        public ActionResult Default()
        {
            return View();
        }
    }
}