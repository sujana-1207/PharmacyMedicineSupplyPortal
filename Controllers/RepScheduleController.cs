using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyMedicineSupply.Models;
using PharmacyMedicineSupply.Provider;

namespace PharmacyMedicineSupply.Controllers
{
    public class RepScheduleController : Controller
    {
        private IRepSchedule _repProvider;
        public RepScheduleController(IRepSchedule repprovider)
        {
            _repProvider = repprovider;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ScheduleDate dates)
        {
            List<RepSchedule> response = await _repProvider.GetSchedule(dates.Date.Date);
            ViewBag.schedule = response;
            return View("Schedule");
        }
    }
}