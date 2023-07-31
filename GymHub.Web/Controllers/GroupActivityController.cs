namespace GymHub.Web.Controllers
{
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.GroupActivity;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class GroupActivityController : Controller
    {
        private readonly IGroupActivityService groupActivityService;
        public GroupActivityController(IGroupActivityService groupActivityService)
        {
            this.groupActivityService = groupActivityService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> AllActivities()
        {
            //Try catch here because there is a possibility for server error
            var model = await groupActivityService.AllActivities();
            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ActivityDetails(Guid id)
        {
            ActivityDetailsViewModel viewModel = await this.groupActivityService.GetActivityModelByIdAsync(id);

            if (viewModel == null)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }
    }
}
