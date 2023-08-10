namespace GymHub.Services.Tests
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.User;
    using Microsoft.EntityFrameworkCore;
    using System;
    public class UserServiceTests
    {
        private DbContextOptions<GymHubDbContext> dbOptions;
        private GymHubDbContext dbContext;

        private IUserService userService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<GymHubDbContext>()
                .UseInMemoryDatabase("GymHubInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.dbContext = new GymHubDbContext(this.dbOptions);
            DatabaseSeeder.SeedDatabase(this.dbContext);

            this.dbContext.Database.EnsureCreated();


            this.userService = new UserService(this.dbContext);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task CheckTraineeUserIsAddedCorrectly()
        {
            // Arrange: Create application user
            var applicationUser = new ApplicationUser()
            {
                Id = Guid.Parse("54b803da-df1b-46ae-8e94-55aad8e5fbc3"),
                FirstName = "Olivia",
                LastName = "Parker",
                PhoneNumber = "447123456789",
                UserName = "olivia.parker@gmail.com",
                NormalizedUserName = "OLIVIA.PARKER@GMAIL.COM",
                Email = "olivia.parker@gmail.com",
                NormalizedEmail = "OLIVIA.PARKER@GMAIL.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEHtfzsAaVxrwVzmZinE9tgvi9jcwvbuQNeYsjc6VSdAWUZ0h1m8qwPcd//FhC0XU+w==",
                SecurityStamp = "2b39aeb0-bbc6-4c8e-9d6e-f0fd53fe0216",
                ConcurrencyStamp = "4adb2ede-4773-4283-8360-e22ca09e4253"
            };

            dbContext.Users.Add(applicationUser);
            dbContext.SaveChanges();

            var userId = applicationUser.Id;

            //Arrange: Make the registered user a Trainee with correct data
            var infoModel = new MoreInfoTraineeViewModel()
            {
                Age = 17,
                Weight = 45,
                Height = 1.69,
                Gender = "Female",
                Level = "Advanced",
            };

            // Act
            await userService.AddTraineeUser(infoModel, userId);

            var addedTrainee = await dbContext.Trainees.FirstOrDefaultAsync(trainee => trainee.UserId == userId);

            // Assert
            Assert.IsNotNull(addedTrainee);  // Verify that a Trainee is added
            Assert.That(addedTrainee.Age, Is.EqualTo(infoModel.Age));
            Assert.That(addedTrainee.Weight, Is.EqualTo(infoModel.Weight));


        }

        [Test]
        public async Task CheckUserTypeExistenceIsMissingOfUserWithoutType()
        {
            // Arrange: Create application user
            var applicationUser = new ApplicationUser()
            {
                Id = Guid.Parse("5b83c610-cb6b-4bab-957a-26854382841d"),
                FirstName = "Test",
                LastName = "Testov",
                PhoneNumber = "447123456789",
                UserName = "test.testov@gmail.com",
                NormalizedUserName = "TEST.TESTOV@GMAIL.COM",
                Email = "test.testov@gmail.com",
                NormalizedEmail = "TEST.TESTOV@GMAIL.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEHtfzsAaVxrwVzmZinE9tgvi9jcwvbuQNeYsjc6VSdAWUZ0h1m8qwPcd/=",
                SecurityStamp = "1785f780-240b-492c-86d8-04c08e40f99c",
                ConcurrencyStamp = "378c8238-fb52-4048-917d-8636664e1659"
            };

            dbContext.Users.Add(applicationUser);
            dbContext.SaveChanges();

            var userId = applicationUser.Id;

            //Act
            var result = await userService.CheckUserTypeExistance(userId);

            Assert.IsFalse(result);
        }


        [Test]
        public async Task CheckUserTypeExistenceReturnsTrue()
        {
            // Arrange: Create application user
            var userIdTrainer = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");
            var userIdTrainee = Guid.Parse("74e67149-8b9d-40e4-a648-8088dff336a4");

            //Act
            var resultTrainer = await userService.CheckUserTypeExistance(userIdTrainer);
            var resultTrainee = await userService.CheckUserTypeExistance(userIdTrainee);

            Assert.IsTrue(resultTrainer);
            Assert.IsTrue(resultTrainee);
        }

        [Test]
        public async Task GetTraineeUserCorrectly()
        {
            // Arrange
            
            var userIdTrainee = Guid.Parse("74e67149-8b9d-40e4-a648-8088dff336a4");

            var expectedTrainee = dbContext.Trainees.First(trainee => trainee.UserId == userIdTrainee);

            //Act
            var resultTrainee = await userService.GetTraineeAsync(userIdTrainee);

            //Assert
            Assert.That(resultTrainee, Is.EqualTo(expectedTrainee));
        }

        [Test]
        public async Task ReturnNullIfTraineeUserNotFound()
        {
            // Arrange
            
            var userIdTrainee = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");

            //Act
            var resultTrainee = await userService.GetTraineeAsync(userIdTrainee);

            //Assert
            Assert.IsNull(resultTrainee);
        }

        [Test]
        public async Task GetTrainerUserCorrectly()
        {
            // Arrange

            var userIdTrainee = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");

            var expectedTrainer = dbContext.Trainers.First(trainee => trainee.UserId == userIdTrainee);

            //Act
            var resultTrainer = await userService.GetTrainerAsync(userIdTrainee);

            //Assert
            Assert.IsNotNull(resultTrainer);
            Assert.That(expectedTrainer.Experience, Is.EqualTo(resultTrainer.Experience));
            Assert.That(expectedTrainer.Bio, Is.EqualTo(resultTrainer.Bio));
            Assert.That(expectedTrainer.Id, Is.EqualTo(resultTrainer.Id));
        }


        [Test]
        public async Task ReturnNullIfTrainerUserNotFound()
        {
            // Arrange

            var userIdTrainer = Guid.Parse("74e67149-8b9d-40e4-a648-8088dff336a4");

            //Act
            var resultTrainer = await userService.GetTrainerAsync(userIdTrainer);

            //Assert
            Assert.IsNull(resultTrainer);
        }
    }
}
