using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Hackathon.BusinessLayer;

namespace Hackathon.DataAccess
{
    public static class Api
    {
        public static async Task<List<Data>> GetDataAsync(string url)
        {
            var data = new List<Data>();
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var stringData = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<List<Data>>(stringData);
                }
            }
            return data;
        }
    }
}