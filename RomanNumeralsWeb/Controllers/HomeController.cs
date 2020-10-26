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
            string convertToDisplay;
            if (romanNumber != null)
            {
                try
                {
                    romanNumber = romanNumber.Trim();
                    var romanToArabic = romanNumber.ToArabicNumerals();
                    var romanToArabicThenToRoman = romanToArabic.ToRomanNumerals();
                    if (romanNumber == romanToArabicThenToRoman)
                        convertToDisplay = $"{romanNumber} signifie {romanToArabic}";
                    else
                        convertToDisplay = $"{romanNumber} pourrait signifier {romanToArabic} mais devrait s'écrire {romanToArabic.ToRomanNumerals()}";
                }
                catch
                {
                    convertToDisplay = "conversion impossible";
                }
                return View((object)convertToDisplay);
            }
            else if (number != 0)
            {
                convertToDisplay = $"{number} s'écrit en chiffres romains {number.ToRomanNumerals()}";
                return View((object)convertToDisplay);
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
