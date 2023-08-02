namespace GymHub.Web.Controllers
{
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.GroupActivity;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class GroupActivityController : BaseController
    {
        private readonly IGroupActivityService groupActivityService;
        private readonly IUserService userService;
        public GroupActivityController(IGroupActivityService groupActivityService, IUserService userService)
        {
            this.groupActivityService = groupActivityService;
            this.userService = userService;
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

        [HttpPost]
        public async Task<IActionResult> EnrollForActivtiy(Guid id)
        {
            var userId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View("ActivityDetails");
            }

            try
            {
                var trainee = await this.userService.GetTraineeAsync(userId);

                await this.groupActivityService.CreateGroupEnrollement(trainee, id);

            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while saving your group activity registration. Please try again later");
                return View("ActivityDetails");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
