using PharmacyMedicineSupply.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply.Provider
{
    public interface IRepSchedule
    {
        public Task<List<RepSchedule>> GetSchedule(DateTime startDate); 
    }
}
