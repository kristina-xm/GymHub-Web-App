namespace GymHub.Services.Tests
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.ViewModels.User;
    using Microsoft.EntityFrameworkCore;
    using System;
    using static GymHub.Common.EntityValidationConstants;

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
            Assert.IsNotNull(resultTrainee);
            Assert.That(expectedTrainee.Level, Is.EqualTo(resultTrainee.Level));
            Assert.That(expectedTrainee.Age, Is.EqualTo(resultTrainee.Age));
            Assert.That(expectedTrainee.Weight, Is.EqualTo(resultTrainee.Weight));
            Assert.That(expectedTrainee.Height, Is.EqualTo(resultTrainee.Height));
            Assert.That(expectedTrainee.UserId, Is.EqualTo(resultTrainee.UserId));
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

        [Test]
        public async Task GetTraineeUserDataCorrectly()
        {
            // Arrange

            var userIdTrainee = Guid.Parse("74e67149-8b9d-40e4-a648-8088dff336a4");

            var trainee = dbContext.Trainees.First(trainee => trainee.UserId == userIdTrainee);
           
            var dataModelExpected = new RegisteredTraineeViewModel
            {
                FirstName = trainee.User.FirstName,
                LastName = trainee.User.LastName,
                PhoneNumber = trainee.User.PhoneNumber,
                Age = trainee.Age,
                Weight = trainee.Weight,
                Height = trainee.Height,
                Gender = trainee.Gender,
                Level = trainee.Level
            };

            //Act
            var resultTrainee = await userService.GetTraineeTypeInfoForEdit(trainee);

            Assert.IsNotNull(resultTrainee);

            var dataModelResult = new RegisteredTraineeViewModel
            {
                FirstName = resultTrainee.FirstName,
                LastName = resultTrainee.LastName,
                PhoneNumber = resultTrainee.PhoneNumber,
                Age = resultTrainee.Age,
                Weight = resultTrainee.Weight,
                Height = resultTrainee.Height,
                Gender = resultTrainee.Gender,
                Level = resultTrainee.Level
            };

            
            //Assert
            Assert.That(dataModelResult.FirstName, Is.EqualTo(dataModelExpected.FirstName));
            Assert.That(dataModelResult.LastName, Is.EqualTo(dataModelExpected.LastName));
            Assert.That(dataModelResult.PhoneNumber, Is.EqualTo(dataModelExpected.PhoneNumber));
            Assert.That(dataModelResult.Age, Is.EqualTo(dataModelExpected.Age));
            Assert.That(dataModelResult.Weight, Is.EqualTo(dataModelExpected.Weight));
            Assert.That(dataModelResult.Height, Is.EqualTo(dataModelExpected.Height));
            Assert.That(dataModelResult.Level, Is.EqualTo(dataModelExpected.Level));
        }

        [Test]
        public async Task GetTrainerUserDataCorrectly()
        {
            // Arrange

            var userIdTrainer = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");

            var trainer = dbContext.Trainers.First(trainee => trainee.UserId == userIdTrainer);

            var dataModelExpected = new RegisteredTrainerViewModel
            {
                Bio = trainer.Bio,
                Experience = trainer.Experience,
            };

            //Act
            var resultTrainee = await userService.GetTrainerTypeInfoForEdit(trainer);

            Assert.IsNotNull(resultTrainee);

            var dataModelResult = new RegisteredTrainerViewModel
            {
                Bio = resultTrainee.Bio,
                Experience = resultTrainee.Experience
            };

            //Assert
            Assert.That(dataModelResult.Bio, Is.EqualTo(dataModelExpected.Bio));
            Assert.That(dataModelResult.Experience, Is.EqualTo(dataModelExpected.Experience));
           
        }

        [Test]
        public async Task EditTraineeUserDataCorrectly()
        {
            // Arrange

            var userIdTrainee = Guid.Parse("74e67149-8b9d-40e4-a648-8088dff336a4");

            var trainee = dbContext.Trainees.First(trainee => trainee.UserId == userIdTrainee);
            int newTraineeWeigth = 67;

            var traineeModel = new RegisteredTraineeViewModel()
            {
                FirstName = "Yana",
                LastName = "Georgieva",
                PhoneNumber = "35987227744",
                Age = 24,
                Weight = newTraineeWeigth,
                Height = 1.70,
                Level = "Intermediate"
            };

            //Act
            await userService.EditTraineeAsync(traineeModel, userIdTrainee);

            //Assert
            Assert.That(trainee.Weight, Is.EqualTo(newTraineeWeigth));
       
        }

        [Test]
        public async Task EditTrainerUserDataCorrectly()
        {
            // Arrange

            var userIdTrainer = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667");

            var trainer = dbContext.Trainers.First(trainer => trainer.UserId == userIdTrainer);
           
            string newBio = "New bio";
            int newExperience = 4;

            var traineeModel = new RegisteredTrainerViewModel()
            {
                Bio = newBio,
                Experience = newExperience
            };

            //Act
            await userService.EditTrainerAsync(traineeModel, userIdTrainer);

            //Assert
            Assert.That(trainer.Bio, Is.EqualTo(newBio));
            Assert.That(trainer.Experience, Is.EqualTo(newExperience));

        }

    }
}
