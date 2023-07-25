using GymHub.Services.Data;
using GymHub.Services.Data.Interfaces;
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
    }
}
