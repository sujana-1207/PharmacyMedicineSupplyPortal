using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PharmacyMedicineSupply.Models;
using PharmacyMedicineSupply.Provider;

namespace PharmacyMedicineSupply.Controllers
{
    public class DemandController : Controller
    {
        DemandProvider _demand = new DemandProvider(); 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Order()
        {
            try
            {
                var inp = _demand.GetMedicineNames();
                ViewBag.names = inp;
                return View();
            }
            catch(Exception e)
            {

            }
            return View();
        }
    }
}
