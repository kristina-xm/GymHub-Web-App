namespace GymHub.Controllers.Tests
{
    using FakeItEasy;
    using GymHub.Data.Models;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.Controllers;
    using GymHub.Web.ViewModels.GroupActivity;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    public class GroupActivityControllerTest
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task AllActivitiesShouldReturnViewWithModel()
        {
            // Arrange
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var fakeUserService = A.Fake<IUserService>();
            var groupActivityController = new GroupActivityController(fakeGroupActivityService, fakeUserService);

            var tempData = new TempDataDictionary(
                new DefaultHttpContext(),
                A.Fake<ITempDataProvider>());

            groupActivityController.TempData = tempData;

           
            var fakeModel = new List<AllActivitiesViewModel>{};

            A.CallTo(() => fakeGroupActivityService.AllActivities()).Returns(fakeModel);

            // Act
            var result = await groupActivityController.AllActivities();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); 
            var viewResult = (ViewResult)result;

            Assert.That(viewResult.Model, Is.EqualTo(fakeModel)); 
            Assert.That(viewResult.ViewData["Title"], Is.EqualTo("Group Activities"));
        }

        [Test]
        public async Task ActivityDetailsShouldReturnRedirectToHomeIndexWhenViewModelIsNull()
        {
            // Arrange
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var fakeUserService = A.Fake<IUserService>();
            var groupActivityController = new GroupActivityController(fakeGroupActivityService, fakeUserService);

            var tempData = new TempDataDictionary(
                new DefaultHttpContext(),
                A.Fake<ITempDataProvider>());

            groupActivityController.TempData = tempData;

        
            var fakeActivityId = Guid.NewGuid();

            // Set up the fake service to return null for viewModel
            A.CallTo(() => fakeGroupActivityService.GetActivityModelByIdAsync(fakeActivityId))
                .Returns((ActivityDetailsViewModel)null);

            // Act
            var result = await groupActivityController.ActivityDetails(fakeActivityId);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result); 
            var redirectToActionResult = (RedirectToActionResult)result;

            Assert.That(redirectToActionResult.ActionName, Is.EqualTo("Index")); 
            Assert.That(redirectToActionResult.ControllerName, Is.EqualTo("Home"));
        }

        [Test]
        public async Task ActivityDetailsShouldReturnViewWithModelWhenViewModelIsNotNull()
        {
            // Arrange
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var fakeUserService = A.Fake<IUserService>();
            var groupActivityController = new GroupActivityController(fakeGroupActivityService, fakeUserService);

            var tempData = new TempDataDictionary(
                new DefaultHttpContext(),
                A.Fake<ITempDataProvider>());

            groupActivityController.TempData = tempData;

            var fakeActivityId = Guid.NewGuid();

            var fakeViewModel = new ActivityDetailsViewModel{};

            A.CallTo(() => fakeGroupActivityService.GetActivityModelByIdAsync(fakeActivityId)).Returns(fakeViewModel);

            // Act
            var result = await groupActivityController.ActivityDetails(fakeActivityId);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); 
            var viewResult = (ViewResult)result;

            Assert.That(viewResult.Model, Is.EqualTo(fakeViewModel));
        }

        [Test]
        public async Task EnrollForActivityShouldReturnRedirectToTraineeAccountOnSuccessfulEnrollment()
        {
            // Arrange
            var fakeGroupActivityService = A.Fake<IGroupActivityService>();
            var fakeUserService = A.Fake<IUserService>();
            var groupActivityController = new GroupActivityController(fakeGroupActivityService, fakeUserService);

            var tempData = new TempDataDictionary(
                new DefaultHttpContext(),
                A.Fake<ITempDataProvider>());

            groupActivityController.TempData = tempData;

            var fakeActivityId = Guid.NewGuid();

       
            var fakeUserId = Guid.NewGuid();

            var fakeTrainee = new Trainee{};

            A.CallTo(() => fakeUserService.GetTraineeAsync(fakeUserId)).Returns(fakeTrainee);

            // Set up the fake service to return false (not enrolled) initially
            A.CallTo(() => fakeGroupActivityService.CheckIfTraineeEnrolled(fakeActivityId)).Returns(false);

            // Set up the fake service to complete successfully
            A.CallTo(() => fakeGroupActivityService.CreateGroupEnrollement(A<Trainee>._, fakeActivityId))
                .DoesNothing(); // No need to simulate any behavior for success

            // Act
            var result = await groupActivityController.EnrollForActivtiy(fakeActivityId);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result); 

            var redirectToActionResult = (RedirectToActionResult)result;

            Assert.That(redirectToActionResult.ActionName, Is.EqualTo("Account")); 

            Assert.That(redirectToActionResult.ControllerName, Is.EqualTo("Trainee")); 


        }
    }
}
