namespace GymHub.Controllers.Tests
{
    using FakeItEasy;
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.ViewModels;
    using GymHub.Web.Controllers;
    using GymHub.Web.ViewModels.Trainee;
    using GymHub.Web.ViewModels.Trainer;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using static GymHub.Common.NotificationConstants;
    public class TraineeControllerTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task AccountReturnsDashboardViewWithViewModel()
        {
            // Arrange
            var fakeTraineeService = A.Fake<ITraineeService>();
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var traineeController = new TraineeController(fakeTraineeService, fakeTrainingService, fakeGroupActivityService);

            var tempData = new TempDataDictionary(
                new DefaultHttpContext(),
                A.Fake<ITempDataProvider>());

            traineeController.TempData = tempData;

            var userId = Guid.NewGuid();
            var expectedViewModel = new MyUpcomingTrainingsViewModel();
            
            A.CallTo(() => fakeTraineeService.GetAllUpcomingTrainings(userId)).Returns(expectedViewModel);

            // Act
            var result = await traineeController.Account();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); 
            var viewResult = (ViewResult)result;
            Assert.That(viewResult.ViewName, Is.EqualTo("Dashboard"));
        }

        [Test]
        public async Task CancelIndividualTrainingWithValidModelReturnsRedirectToAction()
        {
            // Arrange
            var fakeTraineeService = A.Fake<ITraineeService>();
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var traineeController = new TraineeController(fakeTraineeService, fakeTrainingService, fakeGroupActivityService);

            var tempData = new TempDataDictionary(
                new DefaultHttpContext(),
                A.Fake<ITempDataProvider>());

            traineeController.TempData = tempData;

            var trainingId = Guid.NewGuid(); 
            var training = new IndividualTraining();
            A.CallTo(() => fakeTrainingService.GetTrainingById(trainingId)).Returns(training);

            // Act
            var result = await traineeController.CancelIndividualTraining(trainingId);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var viewResult = (RedirectToActionResult)result;

            Assert.That(viewResult.ActionName, Is.EqualTo("Account"));

            A.CallTo(() => fakeTrainingService.CancelTraining(training)).MustHaveHappenedOnceExactly();

            Assert.That(traineeController.TempData[SuccessMessage], Is.EqualTo("You have successfully cancelled this training"));
        }

        [Test]
        public async Task CancelIndividualTrainingWithInvalidModelReturnsRedirectToAction()
        {
            // Arrange
            var fakeTraineeService = A.Fake<ITraineeService>();
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var traineeController = new TraineeController(fakeTraineeService, fakeTrainingService, fakeGroupActivityService);

            traineeController.ModelState.AddModelError("key", "model error");

            // Act
            var result = await traineeController.CancelIndividualTraining(Guid.NewGuid());

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectToActionResult = (RedirectToActionResult)result;

            Assert.AreEqual("Account", redirectToActionResult.ActionName);
            Assert.AreEqual("Trainee", redirectToActionResult.ControllerName);

            A.CallTo(() => fakeTrainingService.CancelTraining(A<IndividualTraining>._)).MustNotHaveHappened();
        }

        [Test]
        public async Task CancelIndividualTrainingWithNullTrainingReturnsRedirectToAction()
        {
            // Arrange
            var fakeTraineeService = A.Fake<ITraineeService>();
            var fakeTrainingService = A.Fake<IIndividualTrainingService>();
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var traineeController = new TraineeController(fakeTraineeService, fakeTrainingService, fakeGroupActivityService);

            var tempData = new TempDataDictionary(
                new DefaultHttpContext(),
                A.Fake<ITempDataProvider>());

            traineeController.TempData = tempData;

            var fakeUserId = Guid.NewGuid();

            A.CallTo(() => fakeTrainingService.GetTrainingById(A<Guid>._))
                .Returns((IndividualTraining)null); 

            // Act
            var result = await traineeController.CancelIndividualTraining(fakeUserId);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectToActionResult = (RedirectToActionResult)result;    

            Assert.That(redirectToActionResult.ActionName, Is.EqualTo("Account"));
            Assert.That(redirectToActionResult.ControllerName, Is.EqualTo("Trainee"));
            Assert.IsNotNull(traineeController.TempData[ErrorMessage]);
        }
    }
}
