﻿namespace GymHub.Web.Controllers
{
    using GymHub.Services.Data;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.IndividualTraining;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using System.Globalization;
    using static GymHub.Common.NotificationConstants;

    public class IndividualTrainingController : BaseController
    {

        private readonly IIndividualTrainingService trainingService;

        public IndividualTrainingController(IIndividualTrainingService trainingService)
        {
            this.trainingService = trainingService;
        }

        [HttpPost]
        public async Task<IActionResult> BookIndividualTraining(BookIndividualTrainingViewModel model, Guid trainerId)
        {
            var userId = GetUserId();

            

            if (model.Day < DateTime.Today)
            {
                TempData[ErrorMessage] = "Day should not be in the past. Enter a valid day";
                return View("_BookIndividualTrainingPartial", model);
            }

            if (model.Start >= model.End)
            {
                TempData[ErrorMessage] = "End time can not be before or the same as Start time";
                return View("_BookIndividualTrainingPartial", model);
            }

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Please, submit correct data";
                return View("_BookIndividualTrainingPartial", model);
            }

            try
            {
                await this.trainingService.CreateTraining(model, trainerId, userId);

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
