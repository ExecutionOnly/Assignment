// **********************************************************************
// * 
// * Copyright (c) BinckBank N.V.
// *
// **********************************************************************

namespace Assignment.Controllers
{
    using System.Web.Mvc;

    using TextService;
    using TextService.Interfaces;

    public class HomeController : Controller
    {
        private readonly IStatisticsService statisticsService;

        public HomeController(IStatisticsService statisticsService)
        {
            this.statisticsService = statisticsService;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string input)
        {
            TextStatistics statistics = this.GenerateStatistics(input);
            return this.View(statistics);
        }

        private TextStatistics GenerateStatistics(string text)
        {
            return new TextStatistics 
            { 
                WordsCount = this.statisticsService.CountWords(text),
                HyphensCount = this.statisticsService.NumberOfHyphens(text),
                SpacesCount = this.statisticsService.NumberOfSpaces(text)
            };
        }
    }
}
