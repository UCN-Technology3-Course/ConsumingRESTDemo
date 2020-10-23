using DesktopApplication.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication
{
    public class RestClient
    {
        static readonly HttpClient client = new HttpClient();

        public async Task<City> GetCityData(string zipCode)
        {
            string uri = $"https://dawa.aws.dk/postnumre/{zipCode}";

            string responseBody = await client.GetStringAsync(uri);

            return JsonConvert.DeserializeObject<City>(responseBody);
        }
    }
}
