using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Hackathon.BusinessLayer;

namespace Hackathon.DataAccess
{
    public class Api : IDisposable
    {
        public void Dispose()
        {
        }

        public async Task<List<Datum>> GetDataAsync(string url)
        {
            var data = new List<Datum>();
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var datum = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<List<Datum>>(datum);
                }
            }
            return data;
        }
    }
}