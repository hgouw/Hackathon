using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;
using Hackathon.DataAccess;
using Hackathon.Web.Models;

namespace Hackathon.Web.Controllers
{
    public class DisplayController : Controller
    {
        [Route("Display")]
        /* TO DO - the code below causes 
         * The resource cannot be found.
         * Description: HTTP 404. The resource you are looking for (or one of its dependencies) could have been removed, had its name changed, or is temporarily unavailable.
         * Please review the following URL and make sure that it is spelled correctly. 
        public async Task<ActionResult> Default()
        {
            var data = await Api.GetDataAsync(ConfigurationManager.AppSettings["ApiUrl"]);
            // TODO - convert data (List<Data>) to dataViewList (List<DataView>)
            var dataModel = new DataModel();
            return View(dataModel.DataViewList);
        }
        */

        public async Task<ActionResult> DefaultAsync()
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            var api = new Api();
            return View("Display", await api.GetDataAsync(ConfigurationManager.AppSettings["ApiUrl"]));
        }
    }
}