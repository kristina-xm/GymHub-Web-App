﻿using Microsoft.AspNetCore.Mvc;

namespace GymHub.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
