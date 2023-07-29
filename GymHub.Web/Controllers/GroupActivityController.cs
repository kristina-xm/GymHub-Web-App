using GymHub.Services.Data;
using GymHub.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymHub.Web.Controllers
{
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
    }
}
