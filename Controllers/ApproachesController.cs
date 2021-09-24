using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWebApp.Controllers
{
    public class ApproachesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult approaches()
        {
            return View();
        }
    }
}
