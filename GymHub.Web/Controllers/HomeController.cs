namespace GymHub.Web.Controllers
{
   
    using GymHub.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using System.Security.Claims;
    using static GymHub.Common.GeneralApplicationConstants;

    public class HomeController : BaseController
    {
        
        public HomeController(ILogger<HomeController> logger)
        {
            
        }

        public IActionResult Index()
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return this.RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404 || statusCode == 400)
            {
                return this.View("Error404");
            }

            if (statusCode == 401)
            {
                return this.View("Error401");
            }

            return this.View();
        }
    }
}