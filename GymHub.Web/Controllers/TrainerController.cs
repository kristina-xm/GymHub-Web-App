using GymHub.Services.Data;
using GymHub.Services.Data.Interfaces;
using GymHub.Web.ViewModels.Trainer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static GymHub.Common.NotificationConstants;

namespace GymHub.Web.Controllers
{
    public class TrainerController : BaseController
    {
        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            this.trainerService = trainerService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> AllTrainers()
        {
            //Try catch here because there is a possibility for server error
            var model = await trainerService.AllTrainers();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> TrainerDetails(Guid id)
        {
            
            TrainerDetailsViewModel viewModel = await this.trainerService.GetTrainerWithScheduleByIdAsync(id);

            if (viewModel == null)
            {
                TempData[ErrorMessage] = "Something went wrong. Please try again later";
                return this.RedirectToAction("Index", "Home");
            }
            else
            {
                TempData[InformationMessage] = "Make sure to check Trainer's schedule before booking an Individual Training.";
            }

            return View(viewModel);

        }

        public async Task<JsonResult> GetEvents(Guid id)
        {
            TrainerDetailsViewModel viewModel = await this.trainerService.GetTrainerWithScheduleByIdAsync(id);

            if (viewModel == null)
            {
                return Json(new { error = "Trainer not found" });
            }

            var indEvents = viewModel.TrainerSchedule.DailySchedules.ToList();
            var groupEvents = viewModel.TrainerSchedule.DailyGroupSchedules.ToList();

            var result = new
            {
                IndividualTrainingEvents = indEvents,
                GroupTrainingEvents = groupEvents
            };

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> Account()
        {
            var user = GetUserId();

            var viewModel = await this.trainerService.GetDashboardData(user);

            if (viewModel == null)
            {
                TempData[ErrorMessage] = "Unexpected error. Please try again later".
            }

            return View("Dashboard", viewModel);
        }
    }
}
