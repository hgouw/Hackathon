using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;
using Hackathon.DataAccess;

namespace Hackathon.Web.Controllers
{
    public class DisplayController : Controller
    {
        [Route("Display")]
        public async Task<string> DefaultAsync()
        {
            var result = "";
            using (var api = new Api())
            {
                var data = await api.GetDataAsync(ConfigurationManager.AppSettings["ApiUrl"]);
            }

            return result;
        }
    }
}