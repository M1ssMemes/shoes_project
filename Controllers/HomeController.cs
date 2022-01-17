using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public IActionResult LastPage()
        {
            return View();
        }

        public IActionResult TestPage()
        {
            return View();
        }

        public IActionResult ResultW(int id)
        {
            return View();
        }

        public IActionResult ResultM(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult TestPage(string sex, string deformation, string temper, string customisation)
        {
            var sexResult = _applicationContext.Sexes.Where(s => s.Value == sex).Select(s => new Sex {ID = s.ID})
                .FirstOrDefault();
            if (sexResult == null)
                return NotFound();

            var deforResult = _applicationContext.Deformations.Where(s => s.Value == deformation)
                .Select(s => new Deformation {ID = s.ID}).FirstOrDefault();
            if (deforResult == null)
                return NotFound();

            var tempResult = _applicationContext.Temperaments.Where(s => s.Value == temper)
                .Select(s => new Temperament {ID = s.ID}).FirstOrDefault();
            if (tempResult == null)
                return NotFound();

            var customResult = _applicationContext.CustomTypes.Where(s => s.Value == customisation)
                .Select(s => new CustomType {ID = s.ID}).FirstOrDefault();
            if (customResult == null)
                return NotFound();

            _applicationContext.Attach(sexResult);
            _applicationContext.Attach(deforResult);
            _applicationContext.Attach(tempResult);
            _applicationContext.Attach(customResult);

            var testAnswer = new TestResults
            {
                Sex = sexResult,
                Deformation = deforResult,
                Temperament = tempResult,
                CustomType = customResult
            };

            _applicationContext.TestResults.Add(testAnswer);
            _applicationContext.SaveChanges();
            var id = testAnswer.ID;


            if (sex == "female")
                return RedirectToAction("ResultW", "Home", new {id});
            return RedirectToAction("ResultM", "Home", new {id});
        }

        [Route("Home/ResultW/{id}")]
        [HttpPost]
        public IActionResult ResultW(int id, string modeltype, string sizechoice)
        {
            return AddChosenModelToDB(id, modeltype, sizechoice);
        }

        [Route("Home/ResultM/{id}")]
        [HttpPost]
        public IActionResult ResultM(int id, string modeltype, string sizechoice)
        {
            return AddChosenModelToDB(id, modeltype, sizechoice);
        }

        private IActionResult AddChosenModelToDB(int id, string modeltype, string sizechoice)
        {
            var modeType = _applicationContext.BaseModels.Where(s => s.Type == modeltype)
                .Select(s => new BaseModel {ID = s.ID}).FirstOrDefault();
            if (modeType == null)
                return NotFound();

            var sizeChoice = _applicationContext.Sizes.Where(s => s.Value == sizechoice)
                .Select(s => new Size {ID = s.ID}).FirstOrDefault();
            if (sizeChoice == null)
                return NotFound();

            var testID = _applicationContext.TestResults.Where(s => s.ID == id).Select(s => new TestResults {ID = s.ID})
                .FirstOrDefault();
            if (testID == null)
                return NotFound();

            _applicationContext.Attach(modeType);
            _applicationContext.Attach(sizeChoice);
            _applicationContext.Attach(testID);

            var chosenModel = new ChosenModel
            {
                BaseModel = modeType,
                Size = sizeChoice,
                TestResults = testID
            };

            _applicationContext.ChosenModels.Add(chosenModel);
            _applicationContext.SaveChanges();

            return RedirectToAction("LastPage", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}