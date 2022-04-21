using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Core.Domain;
using Core.Enum;

namespace Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DataContext _dbContext;

    public HomeController(ILogger<HomeController> logger, DataContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
        public ActionResult Reset()
        {
            var dashboard = _dbContext.Dashboard;

            dashboard.BuildHouseJobsRun = 0;
            dashboard.PaintingJobsRun = 0;
            dashboard.PlumbingJobsRun = 0;
            dashboard.SalesJobsRun = 0;
            dashboard.SayHelloJobsRun = 0;
            dashboard.WeldingJobsRun  = 0;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DoSayHelloJob(int? quantity)
        {
            Run(JobType.Hello, quantity);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DoBuildHouseJob(int? quantity)
        {
            Run(JobType.House, quantity);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DoPlumbingJob(int? quantity)
        {
            Run(JobType.Plumbing, quantity);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DoPaintingJob(int? quantity)
        {
            Run(JobType.Painting, quantity);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DoSalesJob(int? quantity)
        {
            Run(JobType.Sales, quantity);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DoWeldingJob(int? quantity)
        {
            Run(JobType.Welding, quantity);

            return RedirectToAction("Index");
        }

        private void Run(JobType jobType, int? quantity)
        {
            var timesToRun = quantity ?? 1;

            for (var i = 0; i < timesToRun; i++)
            {
                SleepyTime();

                switch (jobType){
                    case JobType.House:
                        _dbContext.Dashboard.BuildHouseJobsRun += 1;
                        break;
                    case JobType.Hello:
                        _dbContext.Dashboard.SayHelloJobsRun += 1;
                        break;
                    case JobType.Painting:
                        _dbContext.Dashboard.PaintingJobsRun += 1;
                        break;
                    case JobType.Plumbing:
                        _dbContext.Dashboard.PlumbingJobsRun += 1;
                        break;
                    case JobType.Sales:
                        _dbContext.Dashboard.SalesJobsRun += 1;
                        break;
                    case JobType.Welding:
                        _dbContext.Dashboard.WeldingJobsRun += 1;
                        break;
                    default:
                        break;
                }
            }
        }

        // This helps us simulate a task taking a while to run
        private void SleepyTime()
        {
            var random = new Random();

            Thread.Sleep(random.Next(1000, 10000));
        }
}