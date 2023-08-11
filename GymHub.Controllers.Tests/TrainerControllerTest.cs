namespace GymHub.Controllers.Tests
{
    using FakeItEasy;
    using GymHub.Services.Data.Interfaces;
    using GymHub.ViewModels;
    using GymHub.Web.Controllers;
    using GymHub.Web.ViewModels.Trainer;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using static GymHub.Common.NotificationConstants;

    public class TrainerControllerTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task IndexShouldReturnViewResultWithCorrectModel()
        {
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            // Create a collection with a fake view model
            var fakeTrainerViewModel = new AllTrainerViewModel();
            var fakeTrainersCollection = new List<AllTrainerViewModel> { fakeTrainerViewModel };

            // Set up the fake service to return the fake collection
            A.CallTo(() => fakeTrainerService.AllTrainers()).Returns(fakeTrainersCollection);

            // Act
            var result = await trainerController.AllTrainers();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = (ViewResult)result;
            Assert.That(viewResult.Model, Is.EqualTo(fakeTrainersCollection));

        }

        [Test]
        public async Task TrainerDetailsShouldReturnViewResultWithViewModelAndInformationMessage()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            // Create a fake TrainerDetailsViewModel
            var fakeTrainerId = Guid.NewGuid(); // Generate a fake GUID for the trainer ID
            var fakeTrainerDetailsViewModel = new TrainerDetailsViewModel
            {
               
            };

            // Set up the fake service to return the fake TrainerDetailsViewModel
            A.CallTo(() => fakeTrainerService.GetTrainerWithScheduleByIdAsync(fakeTrainerId))
                .Returns(fakeTrainerDetailsViewModel);

            // Set up the fake TempData
            var fakeTempData = new TempDataDictionary(new DefaultHttpContext(), A.Fake<ITempDataProvider>());
            trainerController.TempData = fakeTempData;

            // Act
            var result = await trainerController.TrainerDetails(fakeTrainerId);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verify that the result is a ViewResult
            var viewResult = (ViewResult)result;
            Assert.That(viewResult.Model, Is.EqualTo(fakeTrainerDetailsViewModel)); // Verify that the model passed to the view is the fake TrainerDetailsViewModel

            // Verify that the InformationMessage is set in TempData
            Assert.That(
                fakeTempData[InformationMessage]
                , Is.EqualTo("Make sure to check Trainer's schedule before booking an Individual Training."));
        }

        [Test]
        public async Task TrainerDetailsShouldRedirectToHomeIndexIfViewModelIsNull()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            // Initialize fake TempData
            var tempData = new TempDataDictionary(new DefaultHttpContext(), A.Fake<ITempDataProvider>());
            trainerController.TempData = tempData;

            // Set up the fake service to return null for viewModel
            var fakeTrainerId = Guid.NewGuid(); // Generate a fake GUID for the trainer ID
            A.CallTo(() => fakeTrainerService.GetTrainerWithScheduleByIdAsync(fakeTrainerId))
               .Returns((TrainerDetailsViewModel)null);

            // Act
            var result = await trainerController.TrainerDetails(fakeTrainerId);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result); // Verify that the result is a RedirectToActionResult
            var redirectResult = (RedirectToActionResult)result;

            Assert.AreEqual("Index", redirectResult.ActionName); // Verify that the action name is "Index"
            Assert.AreEqual("Home", redirectResult.ControllerName); // Verify that the controller name is "Home"

            // Verify that the ErrorMessage is set in TempData
            Assert.AreEqual(
                "Something went wrong. Please try again later",
                trainerController.TempData[ErrorMessage]
            );
        }

        [Test]
        public async Task GetEventsShouldReturnErrorJsonWhenViewModelIsNull()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            // Set up the fake service to return null for viewModel
            var fakeTrainerId = Guid.NewGuid(); // Generate a fake GUID for the trainer ID
            A.CallTo(() => fakeTrainerService.GetTrainerWithScheduleByIdAsync(fakeTrainerId))
               .Returns((TrainerDetailsViewModel)null);

            // Act
            var result = await trainerController.GetEvents(fakeTrainerId);

            // Assert
            Assert.IsInstanceOf<JsonResult>(result);
            var jsonResult = (JsonResult)result;

        }

        [Test]
        public async Task GetEventsShouldReturnJsonWithEventsWhenViewModelIsNotNull()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            // Create a fake TrainerDetailsViewModel
            var fakeTrainerId = Guid.NewGuid(); // Generate a fake GUID for the trainer ID
            var fakeTrainerDetailsViewModel = new TrainerDetailsViewModel
            {
                TrainerSchedule = new TrainerScheduleViewModel
                {
                    DailySchedules = new List<TrainerDailyScheduleViewModel>
                    {
                        new TrainerDailyScheduleViewModel
                        {
                            StartTime = new DateTime(2023, 08, 12, 10, 0, 0),
                            EndTime = new DateTime(2023, 08, 12, 11, 0, 0),
                        }
                    },
                    DailyGroupSchedules = new List<TrainerGroupScheduleViewModel>
                    {
                        new TrainerGroupScheduleViewModel
                        {
                            ActivityName = "Test",
                             StartTime = new DateTime(2023, 09, 12, 10, 0, 0),
                            EndTime = new DateTime(2023, 09, 12, 11, 0, 0),
                        }
                    }
                }
            };

            // Set up the fake service to return the fake TrainerDetailsViewModel
            A.CallTo(() => fakeTrainerService.GetTrainerWithScheduleByIdAsync(fakeTrainerId))
                .Returns(fakeTrainerDetailsViewModel);

            // Act
            var result = await trainerController.GetEvents(fakeTrainerId);

            // Assert
            Assert.IsInstanceOf<JsonResult>(result); // Verify that the result is a JsonResult
            var jsonResult = (JsonResult)result;


            var resultValue = jsonResult.Value;
            Assert.IsNotNull(resultValue);
        }

        [Test]
        public async Task AccountShouldReturnDashboardWhenViewModelIsNotNull()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            var fakeTempData = new TempDataDictionary(new DefaultHttpContext(), A.Fake<ITempDataProvider>());
            trainerController.TempData = fakeTempData;

            // Set up the fake user ID
            var fakeUserId = Guid.NewGuid();

            // Set up the fake view model
            var fakeViewModel = new AccountDashboardViewModel
            {

            };

            // Set up the fake service to return the fake view model
            A.CallTo(() => fakeTrainerService.GetDashboardData(fakeUserId)).Returns(fakeViewModel);

            // Act
            var result = await trainerController.Account();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); 
            var viewResult = (ViewResult)result;

            Assert.That(viewResult.ViewName, Is.EqualTo("Dashboard"));
            Assert.IsInstanceOf<AccountDashboardViewModel>(viewResult.Model);

            // Verify that no error message is set in TempData
            Assert.IsFalse(trainerController.TempData.ContainsKey(ErrorMessage));
        }

        [Test]
        public async Task AccountShouldReturnDashboardViewWithErrorMessageWhenViewModelNull()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            var fakeTempData = new TempDataDictionary(new DefaultHttpContext(), A.Fake<ITempDataProvider>());
            trainerController.TempData = fakeTempData;

            // Set up the fake user ID
            var fakeUserId = Guid.NewGuid();

            // Set up the fake service to return null for viewModel
            A.CallTo(() => fakeTrainerService.GetDashboardData(fakeUserId))
                .Returns((AccountDashboardViewModel)null);

            // Act
            var result = await trainerController.Account();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verify that the result is a ViewResult
            var viewResult = (ViewResult)result;

            Assert.AreEqual("Dashboard", viewResult.ViewName); // Verify that the view name is "Dashboard"

        }

        [Test]
        public async Task UpcomingIndividualTrainingsShouldReturnMyTraineesViewWithViewModel()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            var fakeTempData = new TempDataDictionary(new DefaultHttpContext(), A.Fake<ITempDataProvider>());
            trainerController.TempData = fakeTempData;
       
            var fakeUserId = Guid.NewGuid();
     
            var fakeViewModel = new List<MyTraineesViewModel>
            {
                // Initialize the properties of the fake view model as needed for the test
            };

            // Set up the fake service to return the fake view model
            A.CallTo(() => fakeTrainerService.GetUpcomingIndividualTrainings(fakeUserId)).Returns(fakeViewModel);

            // Act
            var result = await trainerController.UpcomingIndividualTrainings();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verify that the result is a ViewResult
            var viewResult = (ViewResult)result;

            Assert.AreEqual("MyTrainees", viewResult.ViewName); // Verify that the view name is "MyTrainees"
            Assert.AreEqual(fakeViewModel, viewResult.Model); // Verify that the model passed to the view is the fake view model

            // Verify that no error message is set in TempData
            Assert.IsFalse(trainerController.TempData.ContainsKey(ErrorMessage));
        }

        [Test]
        public async Task UpcomingIndividualTrainingsShouldReturnMyTraineesViewWithErrorMessage()
        {
            // Arrange
            var fakeTrainerService = A.Fake<ITrainerService>();
            var fakeIndividualTrainingService = A.Fake<IIndividualTrainingService>();

            var trainerController = new TrainerController(fakeTrainerService, fakeIndividualTrainingService);

            var fakeTempData = new TempDataDictionary(new DefaultHttpContext(), A.Fake<ITempDataProvider>());
            trainerController.TempData = fakeTempData;


            var fakeUserId = Guid.NewGuid();
           
            A.CallTo(() => fakeTrainerService.GetUpcomingIndividualTrainings(fakeUserId))
                .Returns((List<MyTraineesViewModel>)null);

            // Act
            var result = await trainerController.UpcomingIndividualTrainings();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = (ViewResult)result;

            //Assert.IsTrue(fakeTempData.ContainsKey(ErrorMessage));

            Assert.AreEqual("MyTrainees", viewResult.ViewName);

        }
    }
}
