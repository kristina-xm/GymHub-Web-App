namespace GymHub.Web.Controllers
{
    using GymHub.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using GymHub.Web.ViewModels.User;
    using GymHub.Services.Data.Interfaces;

    public class UserController : BaseController
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserStore<ApplicationUser> userStore;
        private readonly IUserService userService;

        public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IUserStore<ApplicationUser> userStore, IUserService userService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.userStore = userStore;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            ApplicationUser user = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            await userManager.SetPhoneNumberAsync(user, model.PhoneNumber);
            await userManager.SetEmailAsync(user, model.Email);
            await userManager.SetUserNameAsync(user, model.Email);

            IdentityResult result =
                await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await signInManager.SignInAsync(user, false);

            return RedirectToAction("ProvideInfo", "User");
        }


        [HttpGet]
        public IActionResult ProvideInfo()
        {

            return View();
        }

        [HttpGet]
        public IActionResult InfoFormTrainee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTrainee(MoreInfoTraineeViewModel model)
        {
            Guid userId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.userService.AddTraineeUser(model, userId);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error while adding your post");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult InfoFormTrainer()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddTrainer(MoreInfoTrainerViewModel model)
        {
            Guid userId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.userService.AddTrainerUser(model, userId);
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
