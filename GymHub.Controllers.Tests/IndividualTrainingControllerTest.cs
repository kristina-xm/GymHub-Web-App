namespace GymHub.Controllers.Tests
{
    using FakeItEasy;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.Controllers;
    using GymHub.Web.ViewModels.IndividualTraining;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using static GymHub.Common.NotificationConstants;
    public class IndividualTrainingControllerTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public async Task BookIndividualTrainingShouldReturnPartialViewWithErrorWhenDayIsInPast()
        {
            // Arrange
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeTrainerService = A.Fake<ITrainerService>();
            var trainingController = new IndividualTrainingController(fakeTrainingService, fakeTrainerService);

            var tempData = new TempDataDictionary(
            new DefaultHttpContext(),
            A.Fake<ITempDataProvider>());

            // Assign the TempData to the controller
            trainingController.TempData = tempData;

            var model = new BookIndividualTrainingViewModel
            {
                Day = DateTime.Today.AddDays(-1), 
            };

            // Act
            var result = await trainingController.BookIndividualTraining(model, Guid.Empty);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verify that the result is a ViewResult
            var viewResult = (ViewResult)result;

            Assert.That(viewResult.ViewName, Is.EqualTo("_BookIndividualTrainingPartial")); // Verify the partial view name

            // Verify that the expected error message is set in TempData
            Assert.IsTrue(trainingController.TempData.ContainsKey(ErrorMessage));
            Assert.That(trainingController.TempData[ErrorMessage], Is.EqualTo("Day should not be in the past. Enter a valid day"));
        }

        [Test]
        public async Task BookIndividualTrainingShouldReturnPartialViewWithErrorWhenEndIsBeforeStart()
        {
            // Arrange
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeTrainerService = A.Fake<ITrainerService>();
            var trainingController = new IndividualTrainingController(fakeTrainingService, fakeTrainerService);

            var tempData = new TempDataDictionary(
            new DefaultHttpContext(),
            A.Fake<ITempDataProvider>());

            // Assign the TempData to the controller
            trainingController.TempData = tempData;

            var model = new BookIndividualTrainingViewModel
            {
                Start = DateTime.Now.AddHours(2),
                End = DateTime.Now.AddHours(1),
            };

            // Act
            var result = await trainingController.BookIndividualTraining(model, Guid.Empty);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verify that the result is a ViewResult
            var viewResult = (ViewResult)result;

            Assert.That(viewResult.ViewName, Is.EqualTo("_BookIndividualTrainingPartial")); // Verify the partial view name

            // Verify that the expected error message is set in TempData
            Assert.IsTrue(trainingController.TempData.ContainsKey(ErrorMessage));
            Assert.That(trainingController.TempData[ErrorMessage], Is.EqualTo("End time can not be before or the same as Start time"));
        }

        [Test]
        public async Task BookIndividualTrainingShouldReturnPartialViewWithErrorOnInvalidModelState()
        {
            // Arrange
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeTrainerService = A.Fake<ITrainerService>();
            var trainingController = new IndividualTrainingController(fakeTrainingService, fakeTrainerService);

            var tempData = new TempDataDictionary(
            new DefaultHttpContext(),
            A.Fake<ITempDataProvider>());

            // Assign the TempData to the controller
            trainingController.TempData = tempData;

            var model = new BookIndividualTrainingViewModel
            {
               Intensity = null,
            };

            // Simulate an invalid model state
            trainingController.ModelState.AddModelError("PropertyName", "Error message");

            // Act
            var result = await trainingController.BookIndividualTraining(model, Guid.Empty);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verify that the result is a ViewResult
            var viewResult = (ViewResult)result;

            Assert.That(viewResult.ViewName, Is.EqualTo("_BookIndividualTrainingPartial")); // Verify the partial view name

            // Verify that the expected error message is set in TempData
            Assert.IsTrue(trainingController.TempData.ContainsKey(ErrorMessage));
            Assert.That(trainingController.TempData[ErrorMessage], Is.EqualTo("Please, submit correct data"));
        }

        [Test]
        public async Task BookIndividualTrainingShouldRedirectToIndexOnSuccess()
        {
            // Arrange
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeTrainerService = A.Fake<ITrainerService>();
            var trainingController = new IndividualTrainingController(fakeTrainingService, fakeTrainerService);

            var tempData = new TempDataDictionary(
            new DefaultHttpContext(),
            A.Fake<ITempDataProvider>());

            // Assign the TempData to the controller
            trainingController.TempData = tempData;

            var model = new BookIndividualTrainingViewModel
            {
                // Set the model with valid data
                // Initialize properties of the model as needed for the test
            };

            // Set up the fake training service to complete successfully
            A.CallTo(() => fakeTrainingService.CreateTraining(A<BookIndividualTrainingViewModel>._, A<Guid>._, A<Guid>._))
                .DoesNothing(); // No need to simulate any behavior for success

            // Act
            var result = await trainingController.BookIndividualTraining(model, Guid.Empty);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result); // Verify that the result is a RedirectToActionResult
            var redirectToActionResult = (RedirectToActionResult)result;

            Assert.That(redirectToActionResult.ActionName, Is.EqualTo("Index")); // Verify the action name in the redirect
            Assert.That(redirectToActionResult.ControllerName, Is.EqualTo("Home")); // Verify the controller name in the redirect

            // Verify that the success message is set in TempData
            Assert.IsTrue(trainingController.TempData.ContainsKey(SuccessMessage));
            Assert.That(trainingController.TempData[SuccessMessage], Is.EqualTo("Individual training was created successfully!"));
        }

        [Test]
        public async Task BookIndividualTrainingShouldReturnPartialViewWithErrorOnException()
        {
            // Arrange
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeTrainerService = A.Fake<ITrainerService>();
            var trainingController = new IndividualTrainingController(fakeTrainingService, fakeTrainerService);

            var tempData = new TempDataDictionary(
            new DefaultHttpContext(),
            A.Fake<ITempDataProvider>());

            // Assign the TempData to the controller
            trainingController.TempData = tempData;

            var model = new BookIndividualTrainingViewModel
            {
                // Set the model with valid data
                // Initialize properties of the model as needed for the test
            };

            // Set up the fake training service to throw an exception
            A.CallTo(() => fakeTrainingService.CreateTraining(A<BookIndividualTrainingViewModel>._, A<Guid>._, A<Guid>._))
                .Throws(new Exception("Simulated exception")); // Simulate an exception

            // Act
            var result = await trainingController.BookIndividualTraining(model, Guid.Empty);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verify that the result is a ViewResult
            var viewResult = (ViewResult)result;

            Assert.That(viewResult.ViewName, Is.EqualTo("_BookIndividualTrainingPartial")); // Verify the partial view name

            // Verify that the ModelState contains the expected error message for the exception
            Assert.IsTrue(trainingController.ModelState.ContainsKey(string.Empty));
            var modelStateEntry = trainingController.ModelState[string.Empty];
            var modelError = modelStateEntry.Errors[0];
            Assert.That(modelError.ErrorMessage, Is.EqualTo("Unexpected error while booking a training"));

            // Ensure that no other error messages are set in TempData
            Assert.IsFalse(trainingController.TempData.ContainsKey(ErrorMessage));
            Assert.IsFalse(trainingController.TempData.ContainsKey(SuccessMessage));
        }
    }
}

    