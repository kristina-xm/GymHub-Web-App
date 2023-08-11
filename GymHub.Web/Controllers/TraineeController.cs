using GymHub.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static GymHub.Common.NotificationConstants;

namespace GymHub.Web.Controllers
{
    public class TraineeController : BaseController
    {
        private readonly ITraineeService traineeService;

        public TraineeController(ITraineeService traineeService)
        {
            this.traineeService = traineeService;
        }


        [HttpGet]
        public async Task<IActionResult> Account()
        {
            var userId = GetUserId();

            var viewModel = await this.traineeService.GetAllUpcomingTrainings(userId);

            if (viewModel == null)
            {
                TempData[ErrorMessage] = "Unexpected error. Please try again later";
            }

            return View("Dashboard", viewModel);
        }
    }
}
