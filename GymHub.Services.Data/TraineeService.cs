using GymHub.Data;
using GymHub.Data.Models;
using GymHub.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymHub.Data.Models;
using GymHub.Web.ViewModels.Trainer;
using GymHub.ViewModels;
using GymHub.Web.ViewModels.Trainee;

namespace GymHub.Services.Data
{
    public class TraineeService : ITraineeService
    {
        private readonly GymHubDbContext dbContext;
        public TraineeService(GymHubDbContext context)
        {
            this.dbContext = context;
        }

        public async Task<MyUpcomingTrainingsViewModel> GetAllUpcomingTrainings(Guid userId)
        {
            var scheduleModel = new MyUpcomingTrainingsViewModel();


            IEnumerable<TraineeDailyScheduleViewModel> upcomingIndividualSchedules = await dbContext.Trainees
                .Where(t => t.User.Id == userId)
                .SelectMany(t => t.Enrollments)
                .Select(enrollment => enrollment.IndividualTraining)
                .Where(training => training.StartTime > DateTime.UtcNow && !training.IsCanceled)
                .Select(training => new TraineeDailyScheduleViewModel
                {
                    
                    Date = training.StartTime.Date,
                    StartTime = training.StartTime,
                    EndTime = training.EndTime,
                    
                })
                .ToArrayAsync();

            scheduleModel.Trainings = upcomingIndividualSchedules;

            IEnumerable<TraineeGroupScheduleViewModel> upcomingGroupSchedules = await dbContext.Trainees
                .Where(trainee => trainee.User.Id == userId)
                .SelectMany(trainee => trainee.GroupEnrollments)
                .SelectMany(enrollment => enrollment.Schedule.GroupActivity.GroupSchedules)
                .Where(schedule => schedule.StartTime > DateTime.UtcNow)
                .Select(schedule => new TraineeGroupScheduleViewModel
                {
                    ActivityName = schedule.GroupActivity.Name,
                    ActivityDay = schedule.StartTime.Date,
                    StartHour = schedule.StartTime,
                    EndHour = schedule.EndTime,
                    // Add other properties as needed
                })
                .ToArrayAsync();

            scheduleModel.Activities = upcomingGroupSchedules;


            return scheduleModel;
        }

        public bool CheckTraineeHasTrainingWithTrainer(Trainee trainee, Guid TrainerId)
        {
           var traineeWithEnrollments = this.dbContext.Trainees
              .Include(t => t.Enrollments)
              .ThenInclude(e => e.IndividualTraining)
              .FirstOrDefault(t => t.Id == trainee.Id);

            var trainingsByTrainer = this.dbContext
              .IndividualTrainingsTrainers
              .Where(trainer => trainer.TrainerId == TrainerId)
              .Select(trainer => trainer.IndividualTraining)
              .ToList();


            bool hasEnrollmentWithTrainer = traineeWithEnrollments.Enrollments
                .Any(enrollment => trainingsByTrainer.Any(training => enrollment.IndividualTraining.Id == training.Id));

            return hasEnrollmentWithTrainer;
        }
    }
}
