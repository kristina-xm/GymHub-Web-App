namespace GymHub.Web.Controllers
{
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.User;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using static GymHub.Common.NotificationConstants;

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
        public async Task<IActionResult> Login(string? returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginViewModel model = new LoginViewModel()
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {


            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result =
                await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "There was an error while logging you in! Please try again later or contact an administrator.");

                return View(model);
            }
            else
            {
                return Redirect(model.ReturnUrl ?? "/User/CheckUserAccountTypeExists");
            }
        }


        [HttpGet]
        public async Task<IActionResult> CheckUserAccountTypeExists()
        {
            Guid userId = GetUserId();

            //Check if the user has already chosen the account type
            if (await userService.CheckUserTypeExistance(userId))
            {
                //User is present in TRAINERS table OR TRAINEES table
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //If the user did not choose account type after registration.
                //Account type is required for normal functionality of the app!
                return RedirectToAction("ProvideInfo", "User");
            }
        }

        [HttpGet]
        public IActionResult ProvideInfo()
        {

            return View();

        }

        [HttpGet]
        public async Task<IActionResult> InfoFormTrainee()
        {
            //Prevent user to access ProvideInfo Forms again if account type is already selected
            var viewResult = await GetAccordingViewForEdit();
            return viewResult;
        }

        [HttpPost]
        public async Task<IActionResult> AddTrainee(MoreInfoTraineeViewModel model)
        {
            Guid userId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View("InfoFormTrainee", model);
            }

            try
            {
                await this.userService.AddTraineeUser(model, userId);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error while adding your post");
                return View("InfoFormTrainee", model);
            }

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public async Task<IActionResult> InfoFormTrainer()
        {

            //Prevent user to access ProvideInfo Forms again if account type is already selected
            var viewResult = await GetAccordingViewForEdit();
            return viewResult;
        }


        [HttpPost]
        public async Task<IActionResult> AddTrainer(MoreInfoTrainerViewModel model)
        {
            Guid userId = GetUserId();

            if (!ModelState.IsValid)
            {
                return View("InfoFormTrainer", model);
            }

            try
            {
                await this.userService.AddTrainerUser(model, userId);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error. Try again later");
                return View("InfoFormTrainer", model);
            }

            return RedirectToAction("Index", "Home");
        }

        

        public async Task<ViewResult> GetAccordingViewForEdit()
        {
            //Prevent user to access ProvideInfo Forms again if account type is already selected
            Guid userId = GetUserId();

            var trainee = await userService.GetTraineeAsync(userId);

            //If user is trainee
            if (trainee != null)
            {
                var model = await this.userService.GetTraineeTypeInfoForEdit(trainee);

                //If the user is trainee return his/her data in a view for edit
                return View("RegisteredTrainee", model);

            }
            else
            { 
                var trainer = await userService.GetTrainerAsync(userId);

                if (trainer != null)
                {
                    //If the user is trainer return his/her data in a view for edit
                    var model = await this.userService.GetTrainerTypeInfoForEdit(trainer);

                    return View("RegisteredTrainer", model);
                }
                else
                {
                    //If user is not a Trainee, neither Trainer -> return view for account select
                    return View();
                }

            }
        }

        [HttpPost]
        public async Task<IActionResult> EditTrainee(RegisteredTraineeViewModel model)
        {
            Guid userId = GetUserId();

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Error! Please review the info you are providing";
                return View("RegisteredTrainee", model);
            }

            try
            {
                await this.userService.EditTraineeAsync(model, userId);
                TempData[SuccessMessage] = "You have successfully edited your information";
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "An error occurred. Please try again later!";
                ModelState.AddModelError(string.Empty, "Unexpected error. Try again later");
                return View("RegisteredTrainee", model);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> EditTrainer(RegisteredTrainerViewModel model)
        {
            Guid userId = GetUserId();

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Error! Please review the info you are providing";
                return View("RegisteredTrainer", model);
            }

            try
            {
                await this.userService.EditTrainerAsync(model, userId);
                TempData[SuccessMessage] = "You have successfully edited your information";
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "An error occurred. Please try again later!";
                ModelState.AddModelError(string.Empty, "Unexpected error. Try again later");
                return View("RegisteredTrainer", model);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}

