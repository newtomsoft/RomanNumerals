using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RomanNumeralsCore;
using RomanNumeralsWeb.Models;

namespace RomanNumeralsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(int number, string romanNumber)
        {
            if (romanNumber != null)
            {
                string convert;
                try
                {
                    convert = romanNumber.ToArabicNumerals().ToString();
                }
                catch
                {
                    convert = "conversion impossible";
                }
                return View((object)convert);
            }
            else if (number != 0)
            {
                var convert = number.ToRomanNumerals();
                return View((object)convert);
            }
            else
            {
                return View((object)"renseignez un champ !");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
