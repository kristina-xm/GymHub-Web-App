using GymHub.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static GymHub.Common.NotificationConstants;

namespace GymHub.Web.Controllers
{
    public class TraineeController : BaseController
    {
        private readonly ITraineeService traineeService;
        private readonly IIndividualTrainingService trainingService;
        private readonly IGroupActivityService groupActivityService;

        public TraineeController(ITraineeService traineeService, IIndividualTrainingService trainingService, IGroupActivityService groupActivityService)
        {
            this.traineeService = traineeService;
            this.trainingService = trainingService;
            this.groupActivityService = groupActivityService;
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

        [HttpPost]
        public async Task<IActionResult> CancelIndividualTraining(Guid TrainingId)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Account", "Trainee");
            }

            try
            {
                var training = await this.trainingService.GetTrainingById(TrainingId);

                if (training == null)
                {
                    TempData[ErrorMessage] = "An error occured. Please try again";
                    return RedirectToAction("Account", "Trainee");
                }
                else
                {
                    await this.trainingService.CancelTraining(training);
                    TempData[SuccessMessage] = "You have successfully cancelled this training";
                }

            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while saving your group activity registration. Please try again later");
                return RedirectToAction("Account", "Trainee");
            }

            return RedirectToAction("Account", "Trainee");
        }

        [HttpPost]
        public async Task<IActionResult> CancelGroupEnrollment(Guid EnrollmentId)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Account", "Trainee");
            }

            try
            {
                var enrollToRemove = await this.groupActivityService.GetEnrollmentById(EnrollmentId);

                if (enrollToRemove == null)
                {
                    TempData[ErrorMessage] = "An error occured. Please try again";
                    return RedirectToAction("Account", "Trainee");
                }
                else
                {
                    await this.groupActivityService.CancelEnrollment(enrollToRemove);
                    TempData[SuccessMessage] = "You have successfully cancelled this training";
                }

            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while saving your group activity registration. Please try again later");
                return RedirectToAction("Account", "Trainee");
            }

            return RedirectToAction("Account", "Trainee");
        }
    }
}
