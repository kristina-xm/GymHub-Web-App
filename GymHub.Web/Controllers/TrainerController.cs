using GymHub.Services.Data;
using GymHub.Services.Data.Interfaces;
using GymHub.Web.ViewModels.Trainer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        ////Should be corrected with asp-route-information
        public async Task<IActionResult> TrainerDetails(Guid id)
        {

            TrainerDetailsViewModel viewModel = await this.trainerService.GetTrainerByIdAsync(id);

            if (viewModel == null)
            {
                return this.RedirectToAction("Index", "Home");
            }


            return View(viewModel);

        }
    }
}
