namespace GymHub.Services.Tests
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

    public static class DatabaseSeeder
    {
        public static ApplicationUser trainerUser;

        public static ApplicationUser traineeUser;

        public static Trainer trainer;

        public static Trainee trainee;


        public static void SeedDatabase(GymHubDbContext dbContext)
        {
            trainerUser = new ApplicationUser()
            {
                Id = Guid.Parse("72abbcd0-db58-4e6d-a3b4-58e09947e667"),
                FirstName = "Sophia",
                LastName = "Nikolova",
                PhoneNumber = "359895598877",
                UserName = "sophia.nikolova@gmail.com",
                NormalizedUserName = "SOPHIA.NIKOLOVA@GMAIL.COM",
                Email = "sophia.nikolova@gmail.com",
                NormalizedEmail = "SOPHIA.NIKOLOVA@GMAIL.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEAiCCxi119P7Wdt5HACevTAKRJhISG5l+Mnkxp9TG2YpqF6KZdr8Vze+a8cyuxmEtQ",
                SecurityStamp = "e5de3b30-0cc4-4d70-97b0-529e69cd096d",
                ConcurrencyStamp = "d87a6c0b-f8bc-41be-92c7-304cf3a5787f",
            };

            traineeUser = new ApplicationUser()
            {
                Id = Guid.Parse("74e67149-8b9d-40e4-a648-8088dff336a4"),
                FirstName = "Yana",
                LastName = "Georgieva",
                PhoneNumber = "35987227744",
                UserName = "yana.georgieva@gmail.com",
                NormalizedUserName = "YANA.GEORGIEVA@GMAIL.COM",
                Email = "yana.georgieva@gmail.com",
                NormalizedEmail = "YANA.GEORGIEVA@GMAIL.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAELHTCK4lvQkj+qbWISvG4lGE3xlXkucQ3QgQDx3XdNMUZ86cI4tKLUE1wrFBgg3LqQ",
                SecurityStamp = "7bdb94d4-d8be-4522-b39d-3f1d20c01a20",
                ConcurrencyStamp = "cd2451f3-566a-4040-8f73-9ab5c7396e2c",
                TwoFactorEnabled = false
            };

            trainer = new Trainer()
            {
                Id = Guid.Parse("cb1f8d41-ac14-47b4-a9bb-72971251ebaa"),
                Bio = "Hello! I'm Sophia Nikolova, your energetic gym trainer. Passionate about helping clients reach fitness goals, I'll guide you with knowledge and motivation.",
                Experience = 6,
                User = trainerUser,
            };

            trainee = new Trainee()
            {
                Age = 24,
                Weight = 57,
                Height = 1.70,
                Level = "Intermediate",
                User = traineeUser,

            };

            var training1 = new IndividualTraining()
            {
                Id = Guid.Parse("2e469a08-4765-40ef-a067-eb728192b47e"),
                StartTime = new DateTime(2023, 07, 23, 10, 0, 0),
                EndTime = new DateTime(2023, 07, 23, 13, 0, 0),
                Intensity = "Low",
                IsCanceled = false,
            };

            dbContext.IndividualTrainings.Add(training1);

            var training2 = new IndividualTraining()
            {
                Id = Guid.Parse("ff69bf6a-2628-45c4-8353-72d9e06c56b3"),
                StartTime = new DateTime(2023, 10, 20, 10, 0, 0),
                EndTime = new DateTime(2023, 10, 20, 13, 0, 0),
                Intensity = "Moderate",
                IsCanceled = false,
            };

            dbContext.IndividualTrainings.Add(training2);

            var trainingTrainer1 = new IndividualTrainingTrainer()
            {
                Trainer = trainer,
                IndividualTraining = training1
            };

            dbContext.IndividualTrainingsTrainers.Add(trainingTrainer1);

            var trainingTrainer2 = new IndividualTrainingTrainer()
            {
                Trainer = trainer,
                IndividualTraining = training2
            };

            dbContext.IndividualTrainingsTrainers.Add(trainingTrainer2);
        

            var pastGroupActivity = new GroupActivity()
            {
                Id = Guid.Parse("3ca02f00-cf8a-4df0-a1da-f68811f66130"),
                Name = "Activity1",
                CategoryId = 4,
                CountOfMaxSpots = 16,
                Description = "Description for activity 1"
            };

            dbContext.GroupActivities.Add(pastGroupActivity);

            var upcomingGroupActitivy = new GroupActivity()
            {
                Name = "UpcomingActivityTest",
                CategoryId = 4,
                CountOfMaxSpots = 16,
                Description = "Description for upcoming activity test"
            };

            dbContext.GroupActivities.Add(upcomingGroupActitivy);


            var groupActivityTrainerPast = new GroupActivityTrainer()
            {
                Trainer = trainer,
                GroupActivity = pastGroupActivity,
            };

            dbContext.GroupActivityTrainers.Add(groupActivityTrainerPast);

            var upcomingGroupActivityTrainer = new GroupActivityTrainer()
            {
                Trainer = trainer,
                GroupActivity = upcomingGroupActitivy,
            };
            dbContext.GroupActivityTrainers.Add(upcomingGroupActivityTrainer);


            dbContext.IndividualTrainingsTrainers.Add(trainingTrainer2);

            var enrollment1 = new Enrollment()
            {
                Trainee = trainee,
                IndividualTraining = training1
            };

            var enrollment2 = new Enrollment()
            {
                Trainee = trainee,
                IndividualTraining = training2
            };

            var groupSchedulePast = new GroupSchedule()
            {
                StartTime = new DateTime(2023, 08, 08, 16, 0, 0),
                EndTime = new DateTime(2023, 08, 08, 17, 30, 0),
                GroupActivity = pastGroupActivity,
                CountOfTrainees = 1
            };

            dbContext.GroupSchedules.Add(groupSchedulePast);

            var groupScheduleUpcoming = new GroupSchedule()
            {
                StartTime = new DateTime(2023, 08, 08, 16, 0, 0).AddMonths(1),
                EndTime = new DateTime(2023, 08, 08, 17, 30, 0).AddMonths(1),
                GroupActivity = upcomingGroupActitivy,
                CountOfTrainees = 1
            };

            dbContext.GroupSchedules.Add(groupScheduleUpcoming);
    

            dbContext.Enrollments.Add(enrollment1);
            dbContext.Enrollments.Add(enrollment2);

            dbContext.Users.Add(trainerUser);
            dbContext.Users.Add(traineeUser);
            dbContext.Trainers.Add(trainer);
            dbContext.Trainees.Add(trainee);
            dbContext.SaveChanges();
        }
    }
}
