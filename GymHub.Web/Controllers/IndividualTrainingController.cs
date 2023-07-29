namespace GymHub.Web.Controllers
{
    using GymHub.Services.Data;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.IndividualTraining;
    using Microsoft.AspNetCore.Mvc;

    public class IndividualTrainingController : BaseController
    {

        private readonly IIndividualTrainingService trainingService;

        public IndividualTrainingController(IIndividualTrainingService trainingService)
        {
            this.trainingService = trainingService;
        }

        [HttpPost]
        public async Task<IActionResult> BookIndividualTraining(BookIndividualTrainingViewModel model, Guid trainerId)
        {
            var userId = GetUserId();
      
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.trainingService.CreateTraining(model, trainerId, userId);

            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error while adding your post");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
