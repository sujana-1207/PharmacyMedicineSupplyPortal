using Newtonsoft.Json;
using PharmacyMedicineSupply.Helpers;
using PharmacyMedicineSupply.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply.Provider
{
    public class DemandProvider
    {
        List<string> medicineNames = new List<string>();
        public async Task<List<string>> GetMedicineNames()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("");
            var response=await client.GetAsync("/api/Medcine/GetAllMedicineStock");
            var jsonString = await response.Content.ReadAsStringAsync();
            var stockDetails = JsonConvert.DeserializeObject<List<MedicineStock>>(jsonString);
            foreach (var i in stockDetails)
                medicineNames.Add(i.Name);
            return medicineNames;
        }
    }
}
