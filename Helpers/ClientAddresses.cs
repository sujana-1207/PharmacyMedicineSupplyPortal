using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply.Helpers
{
    public class ClientAddresses
    {
        HttpClient client;
        public HttpClient GetAuthAddress()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44300/User/Login");
            return client;
        }
        public HttpClient GetDemandAddress()
        {
            return client;
        }
        public HttpClient GetStockAddress()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("");
            return client;
        }
        public HttpClient GetScheduleAddress()
        {
            return client;
        }
    }
}
