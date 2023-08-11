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
                    TrainingId = training.Id,
                    Date = training.StartTime.Date,
                    StartTime = training.StartTime,
                    EndTime = training.EndTime,
                    
                })
                .ToArrayAsync();

            scheduleModel.Trainings = upcomingIndividualSchedules;

            //IEnumerable<TraineeGroupScheduleViewModel> upcomingGroupSchedules = await dbContext.Trainees
            //    .Where(trainee => trainee.User.Id == userId)
            //    .SelectMany(trainee => trainee.GroupEnrollments)
            //    .Where(ge => ge.IsCanceled == false)
            //    .Select(enrollment => enrollment.Schedule)
            //    .Where(schedule => schedule.StartTime > DateTime.UtcNow)
            //    .Select(schedule => new TraineeGroupScheduleViewModel
            //    {
            //        EnrollmentId = schedule.GroupEnrollments.Where(schedule => schedule.Id == Enrollment.).First().Id,
            //        ActivityId = schedule.Id,
            //        ActivityName = schedule.GroupActivity.Name,
            //        ActivityDay = schedule.StartTime.Date,
            //        StartHour = schedule.StartTime,
            //        EndHour = schedule.EndTime,
            //    })
            //    .ToArrayAsync();

            IEnumerable<TraineeGroupScheduleViewModel> upcomingGroupSchedules = await dbContext.Trainees
                .Where(trainee => trainee.User.Id == userId)
                .SelectMany(trainee => trainee.GroupEnrollments)
                .Where(ge => !ge.IsCanceled)
                .Where(ge => ge.Schedule.StartTime > DateTime.UtcNow)
                .Select(enrollment => new TraineeGroupScheduleViewModel
                {
                    EnrollmentId = enrollment.Id,
                    ActivityName = enrollment.Schedule.GroupActivity.Name,
                    ActivityDay = enrollment.Schedule.StartTime.Date,
                    StartHour = enrollment.Schedule.StartTime,
                    EndHour = enrollment.Schedule.EndTime,
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
