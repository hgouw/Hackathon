using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
using Hackathon.BusinessLayer;

namespace Hackathon.DataAccess
{
    public class Api : IDisposable
    {
        public void Dispose()
        {
        }

        //public async Task<string> GetDataAsync(string url)
        public string GetData(string url)
        {
            string result = string.Empty;
            /*
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    //var responseResult = JsonConvert.DeserializeObject<Response>
                }
            }
            */
            return result;
        }
    }
}