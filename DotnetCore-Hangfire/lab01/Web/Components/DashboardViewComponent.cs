using Web.Models;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Web.Components
{
    public class DashboardViewComponent : ViewComponent
    {
        private readonly DataContext _context;

        public DashboardViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dashboard = _context.Dashboard;
            var viewModel = new DashboardViewModel(){
                SalesJobsRun = dashboard.SalesJobsRun,
                SayHelloJobsRun = dashboard.SayHelloJobsRun,
                BuildHouseJobsRun = dashboard.BuildHouseJobsRun,
                PaintingJobsRun = dashboard.PaintingJobsRun,
                PlumbingJobsRun = dashboard.PlumbingJobsRun,
                WeldingJobsRun = dashboard.WeldingJobsRun
            };

            return View(viewModel);
        }
    }
}