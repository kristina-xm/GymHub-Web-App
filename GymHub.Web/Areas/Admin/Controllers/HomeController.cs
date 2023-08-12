using Microsoft.AspNetCore.Mvc;
using GymHub.Web.Areas.Admin.ViewModels;
using GymHub.Services.Data;
using GymHub.Web.Areas.Admin.Services;
using GymHub.Web.Areas.Admin.Services.Interfaces;

namespace GymHub.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        private readonly IAllUsersService service;

        public HomeController(IAllUsersService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllTrainers()
        {
            var model = await service.GetAllUsersTrainers();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllTrainees()
        {
            var model = await service.GetAllUsersTrainees();
            return View(model);
        }
    }
}
