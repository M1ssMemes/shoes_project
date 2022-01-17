using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _applicationContext;

        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext)
        {
            _logger = logger;
            _applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestPage()
        {

            return View();
        }

        [HttpPost]
        public IActionResult TestPage(string sex, string deformation, string temper, string customisation)
        {
            var sexResult  =_applicationContext.Sexes.Where(s => s.Value == sex).Select(s => new Sex(){ID = s.ID}).FirstOrDefault();
            if (sexResult == null)
                return NotFound();

            var deforResult = _applicationContext.Deformations.Where(s => s.Value == deformation).Select(s => new Deformation() { ID = s.ID }).FirstOrDefault();
            if (deforResult == null)
                return NotFound();

            var tempResult = _applicationContext.Temperaments.Where(s => s.Value == temper).Select(s => new Temperament() { ID = s.ID }).FirstOrDefault();
            if (tempResult == null)
                return NotFound();

            var customResult = _applicationContext.CustomTypes.Where(s => s.Value == customisation).Select(s => new CustomType() { ID = s.ID }).FirstOrDefault();
            if (customResult == null)
                return NotFound();

            _applicationContext.Attach(sexResult);
            _applicationContext.Attach(deforResult);
            _applicationContext.Attach(tempResult);
            _applicationContext.Attach(customResult);

            var testanswer = new TestResults
            {
                Sex = sexResult,
                Deformation = deforResult,
                Temperament = tempResult,
                CustomType = customResult
            };

            _applicationContext.TestResults.Add(testanswer);
            _applicationContext.SaveChanges();
            

            return RedirectToAction("Result", "Home");
        }

        public IActionResult Result()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
