namespace GymHub.Services.Tests
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data;
    using GymHub.Services.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class TrainerServiceTests
    {
        private DbContextOptions<GymHubDbContext> dbOptions;
        private GymHubDbContext dbContext;

        private ITrainerService trainerService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<GymHubDbContext>()
                .UseInMemoryDatabase("GymHubInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.dbContext = new GymHubDbContext(this.dbOptions);
            DatabaseSeeder.SeedDatabase(this.dbContext);

            this.dbContext.Database.EnsureCreated();


            this.trainerService = new TrainerService(this.dbContext);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task AllTrainersReturnsTrainersFromDatabase()
        {
            // Arrange
            // No additional arrange steps needed, as the setup is done in OneTimeSetUp.

            // Act
            var result = await trainerService.AllTrainers();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any()); // Check if there is at least one trainer

        }

        [Test]
        public async Task CheckIndividualTrainingsCountOfTrainer()
        {
            //Arrange
            var trainerId = Guid.Parse("cb1f8d41-ac14-47b4-a9bb-72971251ebaa");
            int expectedCount = 2;

            // Act
            var result = await trainerService.GetIndividualTrainingsSchedule(trainerId);

            // Assert
            Assert.That(result, Has.Count.EqualTo(expectedCount));
        }


        [Test]
        public async Task GetIndividualTrainingsOfTrainer()
        {
            //Arrange
            var trainerId = Guid.Parse("cb1f8d41-ac14-47b4-a9bb-72971251ebaa");
            ICollection<IndividualTraining> expectedTrainings = new List<IndividualTraining>();

            var expectedTrainingStartDate1 = new DateTime(2023, 07, 23, 10, 0, 0);
            var expectedTrainingEndDate1 = new DateTime(2023, 07, 23, 13, 0, 0);
            var expectedTrainingStartDate2 = new DateTime(2023, 10, 20, 10, 0, 0);
            var expectedTrainingEndDate2 = new DateTime(2023, 10, 20, 13, 0, 0);

            var expectedTraining1 = new IndividualTraining()
            {
                StartTime = expectedTrainingStartDate1,
                EndTime = expectedTrainingEndDate1,
            };

            expectedTrainings.Add(expectedTraining1);

            var expectedTraining2 = new IndividualTraining()
            {
                StartTime = expectedTrainingStartDate2,
                EndTime = expectedTrainingEndDate2,
            };

            expectedTrainings.Add(expectedTraining2);

            // Act
            var result = await trainerService.GetIndividualTrainingsSchedule(trainerId);

            //Assert
            foreach (var expected in expectedTrainings)
            {
                Assert.IsTrue(result.Any(actual =>
                    actual.StartTime == expected.StartTime && actual.EndTime == expected.EndTime
                ), "Expected training not found in result");
            }

        }

        [Test]
        public async Task CheckGroupActivitiesCountOfTrainer()
        {
            //Arrange
            var userId = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");
            var expectedCount = 1;

            // Act
            var result = await trainerService.GetDashboardData(userId);

            // Assert
            Assert.That(result.CountOfManagedGroupActivities, Is.EqualTo(expectedCount));
        }

        [Test]
        public async Task CheckUpcomingIndividualTrainingsCountOfTrainer()
        {
            //Arrange
            var userId = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");
            int expectedCount = 1;

            // Act
            var result = await trainerService.GetDashboardData(userId);

            // Assert
            Assert.That(result.UpcomingIndividualTrainings, Is.EqualTo(expectedCount));
        }

        [Test]
        public async Task CheckPastGroupSchedulesCountOfTrainerNotIncluded()
        {
            //Arrange
            var userId = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");
            int expectedCountOfUpcoming = 1; //There is only one upcoming. The other one is past and we expect only the activity which is still in the future 
          

            // Act
            var result = await trainerService.GetDashboardData(userId);

            // Assert
            Assert.That(result.UpcomingGroupTrainings, Is.EqualTo(expectedCountOfUpcoming));
        }

        [Test]
        public async Task CheckUpcomingGroupSchedulesCountOfTrainer()
        {
            //Arrange
            var userId = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");
            int expectedCount = 1; //The upcoming group schedule
            
            
            // Act
            var result = await trainerService.GetDashboardData(userId);

            // Assert
            Assert.That(result.UpcomingGroupTrainings, Is.EqualTo(expectedCount));
        }
    }
}